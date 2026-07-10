Changelog - Versão 1.2.0
EN
New Features
- Independent Toggles: You can now enable or disable Noise and Air pollution absorption completely separately.
- Global Support (9 Languages): Added native translations for English, German, French, Spanish, Italian, Japanese, Korean, Polish, and Russian.

Optimization
- Optimized Unity Jobs: Disabling a pollution type now forces the processor to completely skip that code block inside the multi-threaded job, keeping the mod extremely lightweight for megacities.

Bug Fixes
- Parameter Segregation: Fixed a bug where Air purification calculations were accidentally reading the Noise config sliders. Each system now responds strictly to its own panel.
- Chinese Language Fix (zh-Hans): Resolved a duplicate dictionary key error that was crashing the mod when loading the Chinese translation.

PT
Novidades
- Controle Independente: Agora você pode ligar/desligar a absorção de Ruído e de Ar separadamente.
- Suporte Global (6 Idiomas): Adicionada tradução nativa para Espanhol, Italiano, Japonês, Coreano, Polonês e Russo.

Otimização
- Uso de Células de Trabalho (Jobs): Se um tipo de poluição estiver desativado, o processador agora pula completamente aquele bloco de código no Unity, mantendo o mod super leve em megacidades.

Correções (Bug Fixes)
- Separação de Parâmetros: Corrigido bug onde o cálculo do Ar lia os sliders de configuração do Ruído. Agora cada um responde estritamente ao seu painel.
- Ajuste no Chinês (zh-Hans): Corrigido o erro de chaves duplicadas no dicionário que crashava o carregamento do idioma chinês.


Changelog - Version 1.1.0

EN
New Features (Advanced Customization)
- Mathematical Factor Control: You can now fine-tune the simulation curves directly in the mod settings!
- Added Logarithmic Factor (LOG) sliders for Noise Pollution (Default: 1.2) and Air Pollution (Default: 3.5).
- Added Parabolic Factor (SQRT) sliders for Noise and Air Pollution (Default: 1.5).
- High-Precision Tuning: The noise absorption radius control (NoiseAbsorptionRadius) now supports decimal values (0.1 steps), allowing a much finer adjustment between 1.0 and 3.0.

Calibration
- Scale Calibration: Fixed the application logic for strengths (m_AirStrength / m_NoiseStrength). The UI percentage (%) values are now properly converted to decimal units instead of acting as direct multipliers, making the curves behave in a much smoother, more realistic, and predictable way.

Performance
- Internal Optimization: Refactored internal scripts and improved code compiler/execution flow for mathematical calculations (removing redundancies).

PT
Novas Funcionalidades (Customização Avançada)
- Controle de Fatores Matemáticos: Agora você pode calibrar as curvas de simulação direto nas configurações do mod!
- Adicionados os sliders de Fator Logarítmico (LOG) para Poluição Sonora (Padrão: 1.2) e do Ar (Padrão: 3.5).
- Adicionados os sliders de Fator Parabólico (SQRT) para Poluição Sonora e do Ar (Padrão: 1.5).
- Maior Precisão nos Ajustes: O controle do raio de absorção de ruído (NoiseAbsorptionRadius) agora aceita valores decimais (passos de 0.1), permitindo um ajuste muito mais fino entre 1.0 e 3.0.

Calibração
- Calibração de Escala: Corrigida a lógica de aplicação das forças (m_AirStrength / m_NoiseStrength). Os valores da interface em porcentagem (%) agora são convertidos corretamente para unidades decimais em vez de entrarem como multiplicadores diretos, tornando o comportamento das curvas muito mais suave, realista e previsível.

Desempenho
- Otimização Interna: Refatoração de scripts e melhoria no fluxo de compilação/execução da lógica matemática (redução de redundâncias no código).