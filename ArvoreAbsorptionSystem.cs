using Game;
using Game.Common;
using Game.Objects;
using Game.Simulation;
using Game.Tools;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;

namespace ArvoreAbsorptionSystem
{
    [BurstCompile]
    [UpdateAfter(typeof(NoisePollutionSystem))]
    [UpdateAfter(typeof(AirPollutionSystem))]
    public partial class ArvoreAbsorptionSystem : GameSystemBase
    {
        private EntityQuery m_TreeQuery;
        private NoisePollutionSystem m_NoiseSystem;
        private AirPollutionSystem m_AirSystem;
        private int m_FrameCounter;
        private NativeArray<int> m_DensityMap;

        private const float MAP_SIZE = 14336f;
        private const int TEXTURE_SIZE = 128;

        protected override void OnCreate()
        {
            base.OnCreate();
            m_NoiseSystem = World.GetOrCreateSystemManaged<NoisePollutionSystem>();
            m_AirSystem = World.GetOrCreateSystemManaged<AirPollutionSystem>();

            m_TreeQuery = GetEntityQuery(
                ComponentType.ReadOnly<Tree>(),
                ComponentType.ReadOnly<Game.Objects.Transform>(),
                ComponentType.Exclude<Deleted>(),
                ComponentType.Exclude<Game.Tools.Temp>()
            );

            m_DensityMap = new NativeArray<int>(TEXTURE_SIZE * TEXTURE_SIZE, Allocator.Persistent);
            RequireForUpdate(m_TreeQuery);
        }

        protected override void OnDestroy()
        {
            if (m_DensityMap.IsCreated) m_DensityMap.Dispose();
            base.OnDestroy();
        }

        protected override void OnUpdate()
        {
            if (Mod.m_Setting == null || !Mod.m_Setting.ModEnabled) return;

            m_FrameCounter++;
            if (m_FrameCounter % Mod.m_Setting.UpdateInterval != 0) return;

            var noiseMap = m_NoiseSystem.GetMap(false, out var noiseDeps);
            var airMap = m_AirSystem.GetMap(false, out var airDeps);

            var clearJob = new ClearDensityJob { m_Density = m_DensityMap };
            var clearHandle = clearJob.Schedule(m_DensityMap.Length, 64, Dependency);

            var countJob = new CountTreesJob
            {
                m_Density = m_DensityMap,
                m_MapSize = MAP_SIZE,
                m_Size = TEXTURE_SIZE
            };
            var countHandle = countJob.Schedule(m_TreeQuery, clearHandle);

            // Injeta os novos parâmetros segregados no Job
            var applyJob = new ApplyDualReductionJob
            {
                m_Noise = noiseMap,
                m_Air = airMap,
                m_Density = m_DensityMap,
                m_DensitySize = TEXTURE_SIZE,

                // Novas Flags de Ativação Segregada (Crie essas propriedades no seu Mod.m_Setting)
                m_NoiseEnabled = Mod.m_Setting.NoiseReductionEnabled,
                m_AirEnabled = Mod.m_Setting.AirReductionEnabled,

                // Variáveis de Ruído
                m_NoiseStrength = Mod.m_Setting.TreeNoiseStrength,
                m_NoiseMode = Mod.m_Setting.NoiseReductionMode,
                m_NoiseRadius = Mod.m_Setting.NoiseAbsorptionRadius,
                m_NoiseLogFactor = Mod.m_Setting.NoiseLogFactor,
                m_NoiseRootFactor = Mod.m_Setting.NoiseRootFactor,

                // Variáveis de Ar
                m_AirStrength = Mod.m_Setting.TreeAirStrength,
                m_AirMode = Mod.m_Setting.AirReductionMode,
                m_AirRadius = Mod.m_Setting.AirAbsorptionRadius,
                m_AirLogFactor = Mod.m_Setting.AirLogFactor,
                m_AirRootFactor = Mod.m_Setting.AirRootFactor,
            };

            JobHandle combinedDeps = JobHandle.CombineDependencies(countHandle, noiseDeps, airDeps);
            Dependency = applyJob.Schedule(noiseMap.Length, 64, combinedDeps);

            m_NoiseSystem.AddWriter(Dependency);
            m_AirSystem.AddWriter(Dependency);
        }

        [BurstCompile]
        public struct ClearDensityJob : IJobParallelFor
        {
            [WriteOnly] public NativeArray<int> m_Density;
            public void Execute(int index) => m_Density[index] = 0;
        }

        [BurstCompile]
        public partial struct CountTreesJob : IJobEntity
        {
            public NativeArray<int> m_Density;
            public float m_MapSize;
            public int m_Size;

            public void Execute(in Game.Objects.Transform transform, in Tree tree)
            {
                if ((tree.m_State & TreeState.Dead) != 0 || (tree.m_State & TreeState.Adult) == 0)
                    return;

                float3 pos = transform.m_Position;
                float cellSize = m_MapSize / m_Size;
                int x = (int)((pos.x + m_MapSize * 0.5f) / cellSize);
                int z = (int)((pos.z + m_MapSize * 0.5f) / cellSize);

                if ((uint)x < (uint)m_Size && (uint)z < (uint)m_Size)
                {
                    int index = x + (z * m_Size);
                    m_Density[index] = m_Density[index] + 1;
                }
            }
        }

        [BurstCompile]
        public struct ApplyDualReductionJob : IJobParallelFor
        {
            public NativeArray<NoisePollution> m_Noise;
            public NativeArray<AirPollution> m_Air;
            [ReadOnly] public NativeArray<int> m_Density;
            public int m_DensitySize;
            public bool m_NoiseEnabled;
            public bool m_AirEnabled;

            // Parâmetros Ruído
            public int m_NoiseStrength; //Força em %
            public int m_NoiseMode; // modo de calculo
            public int m_NoiseRadius; // raio
            public float m_NoiseLogFactor; //constante do log
            public float m_NoiseRootFactor; //constante da raizq

            // Parâmetros Ar
            public int m_AirStrength;
            public int m_AirMode;
            public int m_AirRadius;
            public float m_AirLogFactor; //constante do log
            public float m_AirRootFactor; //constante da raizq

            public void Execute(int i)
            {
                int mapSize = (int)math.sqrt(m_Noise.Length);
                int noiseX = i % mapSize;
                int noiseZ = i / mapSize;

                int centerDensityX = (int)((float)noiseX / mapSize * m_DensitySize);
                int centerDensityZ = (int)((float)noiseZ / mapSize * m_DensitySize);

                // --- PROCESSAMENTO DO RUÍDO ---
                if (m_NoiseEnabled)
                {
                    float effectiveNoiseTreeCount = GetEffectiveTreeCount(centerDensityX, centerDensityZ, m_NoiseRadius);
                    if (effectiveNoiseTreeCount > 0f)
                    {
                        float noiseReduction = 0f;
                        float noiseForceFactor = m_NoiseStrength / 100f;
                        float noiseLogFactor = m_NoiseLogFactor;
                        float noiseRootFactor = m_NoiseRootFactor;

                        // Switch para processar o modo escolhido pelo usuário no menu
                        switch (m_NoiseMode)
                        {
                            case 1: // Realista (Logarítmico)
                                noiseReduction = math.log10(effectiveNoiseTreeCount + 1f) * (noiseForceFactor + noiseLogFactor);
                                break;

                            case 2: // Parabólico (Raiz Quadrada)
                                noiseReduction = math.sqrt(effectiveNoiseTreeCount) * (noiseForceFactor * noiseRootFactor);
                                break;

                            default: // Caso 0: Linear (Padrão)
                                noiseReduction = effectiveNoiseTreeCount * noiseForceFactor;
                                break;
                        }

                        // Aplica o resultado final calculado no mapa do jogo
                        NoisePollution noiseData = m_Noise[i];
                        int currentNoise = (int)noiseData.m_PollutionTemp;
                        noiseData.m_PollutionTemp = (short)math.max(0, currentNoise - (int)noiseReduction);
                        m_Noise[i] = noiseData;
                    }
                }

                // --- PROCESSAMENTO DO AR ---
                if (m_AirEnabled)
                {
                    float effectiveAirTreeCount = GetEffectiveTreeCount(centerDensityX, centerDensityZ, m_AirRadius);
                    if (effectiveAirTreeCount > 0f)
                    {
                        float airReduction = 0f;
                        float airFactorForce = m_AirStrength / 100f;
                        float airLogFactor = m_AirLogFactor;
                        float airRootFactor = m_AirRootFactor;

                        // Switch para processar o modo escolhido para o Ar no menu
                        switch (m_AirMode)
                        {
                            case 1: // Realista (Logarítmico Base 10)
                                    // Multiplicamos por 3.32f para compensar a escala menor do log10
                                airReduction = math.log10(effectiveAirTreeCount + 1f) * (airFactorForce + airLogFactor);
                                break;

                            case 2: // Parabólico (Raiz Quadrada)
                                    // Multiplicamos por 1.5f para equilibrar a curva com os outros modos
                                airReduction = math.sqrt(effectiveAirTreeCount) * (airFactorForce * airRootFactor);
                                break;

                            default: // Caso 0: Linear (Padrão)
                                airReduction = effectiveAirTreeCount * airFactorForce;
                                break;
                        }

                        // Aplica o resultado final calculado no mapa de poluição do ar do jogo
                        AirPollution airData = m_Air[i];
                        int currentAir = (int)airData.m_Pollution;
                        airData.m_Pollution = (short)math.max(0, currentAir - (int)airReduction);
                        m_Air[i] = airData;
                    }
                }
            }

            // Método auxiliar interno refinado para rodar dentro do Burst executando raios diferentes
            private float GetEffectiveTreeCount(int centerX, int centerZ, int radius)
            {
                if (radius <= 0)
                {
                    int densityIndex = centerX + (centerZ * m_DensitySize);
                    return m_Density[densityIndex];
                }

                float count = 0f;
                for (int offsetZ = -radius; offsetZ <= radius; offsetZ++)
                {
                    for (int offsetX = -radius; offsetX <= radius; offsetX++)
                    {
                        int targetX = centerX + offsetX;
                        int targetZ = centerZ + offsetZ;

                        if (targetX >= 0 && targetX < m_DensitySize && targetZ >= 0 && targetZ < m_DensitySize)
                        {
                            int neighborIndex = targetX + (targetZ * m_DensitySize);
                            int rawCount = m_Density[neighborIndex];

                            if (rawCount > 0)
                            {
                                float distance = math.sqrt(offsetX * offsetX + offsetZ * offsetZ);
                                if (distance <= radius)
                                {
                                    float weight = 1.0f - (distance / (radius + 1f));
                                    count += rawCount * weight;
                                }
                                else if (offsetX == 0 || offsetZ == 0)
                                {
                                    float weight = 1.0f - (distance / (radius + 1f));
                                    count += rawCount * math.max(0f, weight);
                                }
                            }
                        }
                    }
                }
                return count;
            }
        }
    }
}