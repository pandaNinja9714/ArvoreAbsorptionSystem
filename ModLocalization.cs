using Colossal;
using Game.Settings;
using System.Collections.Generic;

namespace ArvoreAbsorptionSystem
{
    // ==================== LOCALIZAÇÃO: INGLÊS (en-US) ====================
    public class LocaleEN : IDictionarySource
    {
        private readonly Setting m_Setting;
        public LocaleEN(Setting setting) => m_Setting = setting;

        public IEnumerable<KeyValuePair<string, string>> ReadEntries(IList<IDictionaryEntryError> errors, Dictionary<string, int> indexCounts)
        {
            return new Dictionary<string, string>
            {
                { m_Setting.GetSettingsLocaleID(), "Árvore Absorption System" },
                { m_Setting.GetOptionTabLocaleID(Setting.kSection), "Main" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModEnabled)), "Mod Enabled" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModEnabled)), "Enable or disable reduction logic for trees." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.UpdateInterval)), "Update Frequency" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.UpdateInterval)), "How often (in frames) maps update. Lower is more accurate but heavier on CPU." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.VerboseLogging)), "Verbose Logging" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.VerboseLogging)), "Enables detailed info in the log file for debugging." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseReductionEnabled)), "Noise Pollution Absorption" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseReductionEnabled)), "Enables or disables the noise pollution absorption system." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirReductionEnabled)), "Air Pollution Absorption" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirReductionEnabled)), "Enables or disables the air pollution absorption system." },


                // NOISE CONTROL (en-US)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TreeNoiseStrength)), "Noise Reduction Strength" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TreeNoiseStrength)), "How much noise each tree absorbs." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseAbsorptionRadius)), "Noise Effect Radius" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseAbsorptionRadius)), "0 = Only exact cell. 1-5 = Nearby cells absorb noise with a distance falloff." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseReductionMode)), "Noise Calculation Mode" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseReductionMode)),
                    "Select the mathematical model for tree sound attenuation:\n\n" +
                    "• LIN (Linear): Flat and constant reduction per tree. Ideal for predictable calculations but less realistic.\n" +
                    "• LOG (Logarithmic): Physics-based curve with diminishing returns. Higher noise levels trigger stronger initial attenuation.\n" +
                    "• SQRT (Parabolic): Square-root-based attenuation. Provides an extremely smooth and balanced reduction gradient across nearby cells." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseLogFactor)), "Logarithmic Factor (Noise Pollution)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseLogFactor)),
                    "Select the constant value for the LOG mode calculation.\n\n" +
                    "• Controls the starting point and base strength of the LOG mode. Since the logarithmic mode simulates sound saturation " +
                    "(where the first few trees absorb a lot of noise and then the effect stabilizes), increasing this factor massively boosts the efficiency of small groves or isolated trees around the city.\n" +
                    "\nOnly works in LOG mode. Default Value = 1.2" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseRootFactor)), "Parabolic Factor (Noise Pollution)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseRootFactor)),
                    "Select the constant value for the SQRT mode calculation.\n\n" +
                    "• Controls the general slope of the square root curve.\n" +
                    "Increasing this value causes tree efficiency to grow more aggressively and linearly.\n" +
                    "Ideal for those who want a balanced middle ground where medium-sized forests absorb noise very effectively.\n" +
                    "\nOnly works in SQRT mode. Default Value = 1.5" },
                
                // AIR CONTROL (en-US)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TreeAirStrength)), "Air Purification Strength" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TreeAirStrength)), "How much air pollution each tree absorbs." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirAbsorptionRadius)), "Air Purification Radius" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirAbsorptionRadius)), "0 = Only exact cell. 1-5 = Nearby cells purify air with a distance falloff." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirReductionMode)), "Air Calculation Mode" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirReductionMode)),
                    "Select the mathematical model for atmospheric tree filtration:\n\n" +
                    "• LIN (Linear): Flat and cumulative purification per canopy. Trees always filter the same absolute value.\n" +
                    "• LOG (Logarithmic): Realistic saturation model. Simulates gas dispersion where large green masses purify critical areas more densely.\n" +
                    "• SQRT (Parabolic): Smooth mathematical transition based on quadratic curves, better simulating the diffuse impact of greenbelts and wind." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirLogFactor)), "Logarithmic Factor (Air Pollution)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirLogFactor)),
                    "Select the constant value for the LOG mode calculation.\n\n" +
                    "Controls the starting point and base strength of the LOG mode. Since the logarithmic mode simulates air saturation " +
                    "(where the first few trees clean up a lot of pollution and then the effect stabilizes), increasing this factor massively boosts the efficiency of small groves or isolated trees around the city.\n" +
                    "\nOnly works in LOG mode. Default Value = 3.5" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirRootFactor)), "Parabolic Factor (Air Pollution)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirRootFactor)),
                    "Select the constant value for the SQRT mode calculation.\n\n" +
                    "• Controls the general slope of the square root curve.\n" +
                    "Increasing this value causes tree efficiency to grow more aggressively and linearly.\n" +
                    "Ideal for those who want a balanced middle ground where medium-sized forests clean the air very effectively.\n" +
                    "\nOnly works in SQRT mode. Default Value = 1.5" },
            };
        }
        public void Unload() { }
    }

    // ==================== LOCALIZAÇÃO: PORTUGUÊS (pt-BR) ====================
    public class LocalePT : IDictionarySource
    {
        private readonly Setting m_Setting;
        public LocalePT(Setting setting) => m_Setting = setting;

        public IEnumerable<KeyValuePair<string, string>> ReadEntries(IList<IDictionaryEntryError> errors, Dictionary<string, int> indexCounts)
        {
            return new Dictionary<string, string>
            {
                { m_Setting.GetSettingsLocaleID(), "Sistema de Absorção por Árvores" },
                { m_Setting.GetOptionTabLocaleID(Setting.kSection), "Principal" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModEnabled)), "Mod Ativado" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModEnabled)), "Chave geral de liga/desliga do mod." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.UpdateInterval)), "Intervalo de Atualização (Frames)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.UpdateInterval)), "Frequência com que os mapas são atualizados (Valores menores pesam mais no processador)." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.VerboseLogging)), "Registro Detalhado (Logs)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.VerboseLogging)), "Ativa informações detalhadas de depuração no arquivo de log do jogo." },

                // NOISE CONTROL (pt-BR)

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseReductionEnabled)), "Absorção de Poluição Sonora" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseReductionEnabled)), "Ativa ou desativa o sistema de absorção de poluição sonora" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TreeNoiseStrength)), "Força da Redução de Ruído" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TreeNoiseStrength)), "O quanto de ruído cada árvore absorve (Em porcentagem)." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseAbsorptionRadius)), "Raio de Abrangência do Ruído" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseAbsorptionRadius)), "0 = Apenas célula exata. 1-5 = Células vizinhas absorvem com atenuação por distância." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseReductionMode)), "Modo de Redução de Ruído" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseReductionMode)),
                    "Selecione o modelo matemático para a atenuação sonora das árvores:\n\n" +
                    "• LIN (Linear): Redução fixa e constante por árvore. Ideal para cálculos previsíveis, mas menos realista.\n" +
                    "• LOG (Logarítmica): Curva baseada em física real com retornos decrescentes. Quanto mais ruído, maior a eficiência inicial de atenuação.\n" +
                    "• SQRT (Parabólica): Atenuação baseada na raiz quadrada. Oferece um gradiente de redução extremamente suave e equilibrado na vizinhança." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseLogFactor)), "Fator Logarítmico (Poluição Sonora)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseLogFactor)),
                    "Selecione o numero de constante para o calculo do modo LOG\n\n" +
                    "• Controla o ponto de partida e a força base do modo LOG. Como o modo logarítmico simula a saturação do barulho \n" +
                    "(onde as primeiras árvores limpam muito e depois o efeito estabiliza), aumentar esse fator potencializa massivamente a eficiência de pequenos bosques ou árvores isoladas pela cidade.\n" +
                    "\n Só funciona no modo LOG. Valor Padrão = 1.2" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseRootFactor)), "Fator Parabólico (Poluição Sonora)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseRootFactor)),
                    "Selecione o numero de constante para o calculo do modo SQRT\n\n" +
                    "• Controla a inclinação geral da curva de raiz quadrada." +
                    "Aumentar esse valor faz com que a eficiência das árvores cresça de forma mais agressiva e linearizada\n" +
                    "- Ideal para quem quer um meio-termo equilibrado onde florestas médias abafam muito bem o barulho.\n" +
                    "\n Só funciona no modo SQRT. Valor Padrão = 1.5" },


                // AIR CONTROL (pt-BR)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirReductionEnabled)), "Absorção de Poluição do Ar" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirReductionEnabled)), "Ativa ou desativa o sistema de absorção de poluição do ar" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TreeAirStrength)), "Força da Purificação do Ar" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TreeAirStrength)), "O quanto de poluição do ar cada árvore filtra (Em porcentagem)." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirAbsorptionRadius)), "Raio de Purificação do Ar" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirAbsorptionRadius)), "0 = Apenas célula exata. 1-5 = Células vizinhas purificam com atenuação por distância." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirReductionMode)), "Modo de Purificação do Ar" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirReductionMode)),
                    "Selecione o modelo matemático para a filtragem atmosférica das árvores:\n\n" +
                    "• LIN (Linear): Filtragem fixa e somatória por copa. Uma árvore sempre purifica o mesmo valor absoluto.\n" +
                    "• LOG (Logarítmica): Modelo de saturação realista. Simula a dispersão de gases onde grandes massas verdes purificam mais densamente áreas críticas.\n" +
                    "• SQRT (Parabólica): Transição matemática suave baseada em curvas quadráticas, simulando melhor o impacto difuso de cinturões verdes e ventos." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirLogFactor)), "Fator Logarítmico (Poluição do Ar)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirLogFactor)),
                    "Selecione o numero de constante para o calculo do modo LOG\n\n" +
                    "• Controla o ponto de partida e a força base do modo LOG. Como o modo logarítmico simula a saturação do ar \n" +
                    "(onde as primeiras árvores limpam muito e depois o efeito estabiliza), aumentar esse fator potencializa massivamente a eficiência de pequenos bosques ou árvores isoladas pela cidade.\n" +
                    "\n Só funciona no modo LOG. Valor Padrão = 3.5" },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirRootFactor)), "Fator Parabólico (Poluição do Ar)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirRootFactor)),
                    "Selecione o numero de constante para o calculo do modo SQRT\n\n" +
                    "• Controla a inclinação geral da curva de raiz quadrada." +
                    "Aumentar esse valor faz com que a eficiência das árvores cresça de forma mais agressiva e linearizada\n" +
                    "Ideal para quem quer um meio-termo equilibrado onde florestas médias limpam muito bem o ar.\n" +
                    "\n Só funciona no modo SQRT. Valor Padrão = 1.5" },
            };
        }

        public void Unload() { }
    }

    // ==================== LOCALIZAÇÃO: ALEMÃO (de-DE) ====================
    public class LocaleDE : IDictionarySource
    {
        private readonly Setting m_Setting;
        public LocaleDE(Setting setting) => m_Setting = setting;

        public IEnumerable<KeyValuePair<string, string>> ReadEntries(IList<IDictionaryEntryError> errors, Dictionary<string, int> indexCounts)
        {
            return new Dictionary<string, string>
            {
                { m_Setting.GetSettingsLocaleID(), "Baumabsorptionssystem" },
                { m_Setting.GetOptionTabLocaleID(Setting.kSection), "Allgemein" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModEnabled)), "Mod aktiviert" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModEnabled)), "Aktiviert oder deaktiviert die Umweltabsorptions-Logik für alle Bäume." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.UpdateInterval)), "Aktualisierungsintervall" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.UpdateInterval)), "Häufigkeit der Aktualisierungen in Frames (Niedrigere Werte belasten CPU stärker)." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.VerboseLogging)), "Ausführliche Protokollierung" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.VerboseLogging)), "Aktiviert detaillierte Debug-Informationen in der Log-Datei." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseReductionEnabled)), "Lärmbelastungsabsorption" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseReductionEnabled)), "Aktiviert oder deaktiviert das System zur Absorption von Lärmbelastung." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirReductionEnabled)), "Luftverschmutzungsabsorption" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirReductionEnabled)), "Aktiviert oder deaktiviert das System zur Absorption von Luftverschmutzung." },
                
                // NOISE CONTROL (de-DE)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TreeNoiseStrength)), "Stärke der Lärmminderung" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TreeNoiseStrength)), "Wie viel Lärm jeder Baum absorbiert." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseAbsorptionRadius)), "Einzugsbereich für Lärmschutz" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseAbsorptionRadius)), "0 = Nur exakte Zelle. 1-5 = Benachbarte Zellen absorbieren mit Distanzabfall." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseReductionMode)), "Modus der Lärmminderung" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseReductionMode)),
                    "Wählen Sie das mathematische Modell für die Schalldämpfung der Bäume:\n\n" +
                    "• LIN (Linear): Konstante Reduzierung pro Baum. Ideal für vorhersehbare Berechnungen, aber weniger realistisch.\n" +
                    "• LOG (Logarithmisch): Realistische physikalische Kurve mit abnehmendem Ertrag. Höherer Lärm führt zu stärkerer Anfangsdämpfung.\n" +
                    "• SQRT (Parabolisch): Quadratwurzel-basierte Dämpfung. Bietet einen extrem sanften und ausgewogenen Übergang in der Umgebung." },
                
                // CORRIGIDO: Idioma Alemão restaurado aqui
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseLogFactor)), "Logarithmischer Faktor (Lärmbelastung)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseLogFactor)),
                    "Wählen Sie den Konstantenwert für die Berechnung im LOG-Modus.\n\n" +
                    "• Steuert den Startpunkt und die Basisstärke des LOG-Modus. Da der logarithmische Modus die Schallsättigung simuliert " +
                    "(wobei die ersten paar Bäume viel Lärm absorbieren und sich der Effekt danach stabilisiert), erhöht eine Erhöhung dieses Faktors die Effizienz von kleinen Hainen oder isolierten Bäumen in der Stadt massiv.\n" +
                    "\nFunktioniert nur im LOG-Modus. Standardwert = 1.2" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseRootFactor)), "Parabolischer Faktor (Lärmbelastung)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseRootFactor)),
                    "Wählen Sie den Konstantenwert für die Berechnung im SQRT-Modus.\n\n" +
                    "• Steuert die allgemeine Steigung der Quadratwurzelkurve.\n" +
                    "Ein höherer Wert führt dazu, dass die Effizienz der Bäume aggressiver und linearer ansteigt.\n" +
                    "Ideal für Spieler, die einen ausgewogenen Mittelweg suchen, bei dem mittlere Wälder den Lärm sehr effektiv dämpfen.\n" +
                    "\nFunktioniert nur im SQRT-Modus. Standardwert = 1.5" },

                // AIR CONTROL (de-DE)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TreeAirStrength)), "Stärke der Luftreinigung" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TreeAirStrength)), "Wie viel Luftverschmutzung jeder Baum herausfiltert." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirAbsorptionRadius)), "Radius der Luftreinigung" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirAbsorptionRadius)), "0 = Nur exakte Zelle. 1-5 = Benachbarte Zellen reinigen mit Distanzabfall." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirReductionMode)), "Modus der Luftreinigung" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirReductionMode)),
                    "Wählen Sie das mathematische Modell für die Luftfilterung der Bäume:\n\n" +
                    "• LIN (Linear): Konstante und kumulative Reinigung pro Baumkrone. Filtert immer denselben absoluten Wert.\n" +
                    "• LOG (Logarithmisch): Realistisches Sättigungsmodell. Simuliert die Gasdispersion, bei der große Grünflächen kritische Zonen dichter reinigen.\n" +
                    "• SQRT (Parabolisch): Sanfter mathematischer Übergang basierend auf quadratischen Kurven zur besseren Simulation von Windschutzstreifen." },
                
                // CORRIGIDO: Idioma Alemão restaurado aqui
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirLogFactor)), "Logarithmischer Faktor (Luftverschmutzung)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirLogFactor)),
                    "Wählen Sie den Konstantenwert für die Berechnung im LOG-Modus.\n\n" +
                    "• Steuert den Startpunkt und die Basisstärke des LOG-Modus. Da der logarithmische Modus die Luftsättigung simuliert " +
                    "(wobei die ersten paar Bäume viel Verschmutzung filtern und sich der Effekt danach stabilisiert), erhöht eine Erhöhung dieses Faktors die Effizienz von kleinen Hainen oder isolierten Bäumen in der Stadt massiv.\n" +
                    "\nFunktioniert nur im LOG-Modus. Standardwert = 3.5" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirRootFactor)), "Parabolischer Faktor (Luftverschmutzung)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirRootFactor)),
                    "Wählen Sie den Konstantenwert für die Berechnung im SQRT-Modus.\n\n" +
                    "• Steuert die allgemeine Steigung der Quadratwurzelkurve.\n" +
                    "Ein höherer Wert führt dazu, dass die Effizienz der Bäume aggressiver und linearer ansteigt.\n" +
                    "Ideal für Spieler, die einen ausgewogenen Mittelweg suchen, bei dem mittlere Wälder die Luft sehr effektiv reinigen.\n" +
                    "\nFunktioniert nur im SQRT-Modus. Standardwert = 1.5" },
            };
        }
        public void Unload() { }
    }

    // ==================== LOCALIZACIÓN: FRANCÊS (fr-FR) ====================
    public class LocaleFR : IDictionarySource
    {
        private readonly Setting m_Setting;
        public LocaleFR(Setting setting) => m_Setting = setting;

        public IEnumerable<KeyValuePair<string, string>> ReadEntries(IList<IDictionaryEntryError> errors, Dictionary<string, int> indexCounts)
        {
            return new Dictionary<string, string>
            {
                { m_Setting.GetSettingsLocaleID(), "Système d'absorption par les arbres" },
                { m_Setting.GetOptionTabLocaleID(Setting.kSection), "Général" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModEnabled)), "Mod activé" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModEnabled)), "Active ou désactive la logique d'absorption environnementale pour tous les arbres." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.UpdateInterval)), "Intervalle de mise à jour" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.UpdateInterval)), "Fréquence de mise à jour en images (Plus bas est plus fluide, mais sollicite le processeur)." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.VerboseLogging)), "Journalisation détaillée" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.VerboseLogging)), "Active les informations de débogage détaillées dans le fichier journal." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseReductionEnabled)), "Absorption de la pollution sonore" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseReductionEnabled)), "Active ou désactive le système d'absorption de la pollution sonore." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirReductionEnabled)), "Absorption de la pollution de l'air" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirReductionEnabled)), "Active ou désactive le système d'absorption de la pollution de l'air." },
                
                // NOISE CONTROL (fr-FR) - CORRIGIDO: Relação Desc/Label e Francês reestabelecidos
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TreeNoiseStrength)), "Force de réduction du bruit" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TreeNoiseStrength)), "Quantité de bruit absorbée par chaque arbre." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseAbsorptionRadius)), "Rayon de captation du bruit" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseAbsorptionRadius)), "0 = Cellule exacte uniquement. 1-5 = Les cellules voisines absorbent avec atténuation." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseReductionMode)), "Mode de réduction du bruit" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseReductionMode)),
                    "Sélectionnez le modèle mathématique pour l'atténuation acoustique des arbres :\n\n" +
                    "• LIN (Linéaire) : Réduction fixe et constante par arbre. Idéal pour des calculs prévisibles, mais moins réaliste.\n" +
                    "• LOG (Logarithmique) : Courbe physique avec rendements décroissants. Un niveau de bruit plus élevé déclenche une atténuation initiale plus forte.\n" +
                    "• SQRT (Parabolique) : Atténuation basée sur la racine carrée. Offre un gradient de réduction extrêmement fluide et équilibré dans le voisinage." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseLogFactor)), "Facteur Logarithmique (Pollution Sonore)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseLogFactor)),
                    "Sélectionnez la valeur de la constante pour le calcul du mode LOG.\n\n" +
                    "• Contrôle le point de départ et la force de base du mode LOG. Comme le mode logarithmique simule la saturation sonore " +
                    "(où les premiers arbres absorbent beaucoup de bruit, puis l'effet se stabilise), l'augmentation de ce facteur stimule massivement l'efficacité des petits bosquets ou des arbres isolés dans la ville.\n" +
                    "\nFonctionne uniquement en mode LOG. Valeur par défaut = 1.2" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseRootFactor)), "Facteur Parabolique (Pollution Sonore)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseRootFactor)),
                    "Sélectionnez la valeur de la constante pour le calcul du mode SQRT.\n\n" +
                    "• Contrôle la pente générale de la courbe de la racine carrée.\n" +
                    "Augmenter cette valeur permet à l'efficacité des arbres de croître de manière plus agressive et linéaire.\n" +
                    "Idéal pour ceux qui recherchent un juste milieu équilibré où les forêts de taille moyenne absorbent très bien le bruit.\n" +
                    "\nFonctionne uniquement en mode SQRT. Valeur par défaut = 1.5" },

                // AIR CONTROL (fr-FR) - CORRIGIDO: Relação Desc/Label e Francês reestabelecidos
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TreeAirStrength)), "Force de purification de l'air" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TreeAirStrength)), "Quantité de pollution de l'air filtrée par chaque arbre." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirAbsorptionRadius)), "Rayon de purification de l'air" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirAbsorptionRadius)), "0 = Cellule exacte uniquement. 1-5 = Les cellules voisines purifient avec atténuation." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirReductionMode)), "Mode de purification de l'air" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirReductionMode)),
                    "Sélectionnez le modèle mathématique pour la filtration atmosphérique des arbres :\n\n" +
                    "• LIN (Linéaire) : Purification fixe et cumulative par canopée. Chaque arbre filtre toujours la même valeur absolue.\n" +
                    "• LOG (Logarithmique) : Modèle de saturation réaliste. Simule la dispersion des gaz où les grandes masses vertes purifient plus densément les zones critiques.\n" +
                    "• SQRT (Parabolique) : Transition mathématique fluide basée sur des courbes quadratiques, simulant mieux l'impact diffus des ceintures vertes." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirLogFactor)), "Facteur Logarithmique (Pollution de l'Air)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirLogFactor)),
                    "Sélectionnez la valeur de la constante pour le calcul du mode LOG.\n\n" +
                    "• Contrôle le point de départ et la force de base du mode LOG. Comme le mode logarithmique simule la saturation de l'air " +
                    "(où les premiers arbres purifient beaucoup de pollution, puis l'effet se stabilise), l'augmentation de ce facteur stimule massivement l'efficacité des petits bosquets ou des arbres isolés dans la ville.\n" +
                    "\nFonctionne uniquement en mode LOG. Valeur par défaut = 3.5" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirRootFactor)), "Facteur Parabolique (Pollution de l'Air)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirRootFactor)),
                    "Sélectionnez la valeur de la constante pour le calcul du mode SQRT.\n\n" +
                    "• Contrôle la pente générale de la courbe de la racine carrée.\n" +
                    "Augmenter cette valeur permet à l'efficacité des arbres de croître de manière plus agressive et linéaire.\n" +
                    "Idéal pour ceux qui recherchent un juste milieu équilibré où les forêts de taille moyenne purifient très bien l'air.\n" +
                    "\nFonctionne uniquement en mode SQRT. Valeur par défaut = 1.5" },
            };
        }
        public void Unload() { }
    }
    // ==================== LOCALIZACIÓN: ESPAÑOL (es-ES) ====================
    public class LocaleES : IDictionarySource
    {
        private readonly Setting m_Setting;
        public LocaleES(Setting setting) => m_Setting = setting;

        public IEnumerable<KeyValuePair<string, string>> ReadEntries(IList<IDictionaryEntryError> errors, Dictionary<string, int> indexCounts)
        {
            return new Dictionary<string, string>
            {
                { m_Setting.GetSettingsLocaleID(), "Sistema de Absorción por Árboles" },
                { m_Setting.GetOptionTabLocaleID(Setting.kSection), "Principal" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModEnabled)), "Mod Activado" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModEnabled)), "Interruptor general para activar/desactivar el mod." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.UpdateInterval)), "Intervalo de Actualización (Fotogramas)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.UpdateInterval)), "Frecuencia con la que se actualizan los mapas (Valores más bajos aumentan la carga del procesador)." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.VerboseLogging)), "Registro Detallado (Logs)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.VerboseLogging)), "Activa información detallada de depuración en el archivo de registro del juego." },

                // NOISE CONTROL (es-ES)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseReductionEnabled)), "Absorción de Contaminación Acústica" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseReductionEnabled)), "Activa o desactiva el sistema de absorción de contaminación acústica." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TreeNoiseStrength)), "Fuerza de Reducción de Ruido" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TreeNoiseStrength)), "Cantidad de ruido que absorbe cada árbol (En porcentaje)." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseAbsorptionRadius)), "Radio de Alcance del Ruido" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseAbsorptionRadius)), "0 = Solo celda exacta. 1-5 = Las celdas vecinas absorben con atenuación por distancia." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseReductionMode)), "Modo de Reducción de Ruido" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseReductionMode)),
                    "Seleccione el modelo matemático para la atenuación acústica de los árboles:\n\n" +
                    "• LIN (Linear): Reducción fija y constante por árbol. Ideal para cálculos predecibles, pero menos realista.\n" +
                    "• LOG (Logarítmica): Curva basada en física real con rendimientos decrecientes. Cuanto mayor sea el ruido, mayor será la eficiencia de atenuación inicial.\n" +
                    "• SQRT (Parabólica): Atenuación basada en la raíz cuadrada. Ofrece un gradiente de reducción extremadamente suave y equilibrado en los alrededores." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseLogFactor)), "Factor Logarítmico (Contaminación Acústica)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseLogFactor)),
                    "Seleccione el número de constante para el cálculo del modo LOG\n\n" +
                    "• Controla el punto de partida y la fuerza base del modo LOG. Como el modo logarítmico simula la saturación del ruido " +
                    "(donde los primeros árboles limpian mucho y luego el efecto se estabiliza), aumentar este factor potencia masivamente la eficiencia de pequeños bosques o árboles aislados por la ciudad.\n" +
                    "\nSolo funciona en modo LOG. Valor Predeterminado = 1.2" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseRootFactor)), "Factor Parabólico (Contaminación Acústica)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseRootFactor)),
                    "Seleccione el número de constante para el cálculo del modo SQRT\n\n" +
                    "• Controla la inclinación general de la curva de raíz cuadrada. " +
                    "Aumentar este valor hace que la eficiencia de los árboles crezca de forma más agresiva y lineal.\n" +
                    "- Ideal para quienes buscan un término medio equilibrado donde bosques medianos amortigüen muy bien el ruido.\n" +
                    "\nSolo funciona en modo SQRT. Valor Predeterminado = 1.5" },

                // AIR CONTROL (es-ES)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirReductionEnabled)), "Absorción de Contaminación del Aire" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirReductionEnabled)), "Activa o desactiva el sistema de absorción de contaminación del aire." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TreeAirStrength)), "Fuerza de Purificación del Aire" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TreeAirStrength)), "Cantidad de contaminación del aire que filtra cada árbol (En porcentaje)." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirAbsorptionRadius)), "Radio de Purificación del Aire" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirAbsorptionRadius)), "0 = Solo celda exacta. 1-5 = Las celdas vecinas purifican con atenuación por distancia." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirReductionMode)), "Modo de Purificación del Aire" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirReductionMode)),
                    "Seleccione el modelo matemático para la filtración atmosférica de los árboles:\n\n" +
                    "• LIN (Linear): Filtración fija y sumatoria por copa. Un árbol siempre purifica el mismo valor absoluto.\n" +
                    "• LOG (Logarítmica): Modelo de saturación realista. Simula la dispersión de gases donde grandes masas verdes purifican más densamente las zonas críticas.\n" +
                    "• SQRT (Parabólica): Transición matemática suave basada en curvas cuadráticas, simulando mejor el impacto difuso de los cinturones verdes y vientos." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirLogFactor)), "Factor Logarítmico (Contaminación del Aire)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirLogFactor)),
                    "Seleccione el número de constante para el cálculo del modo LOG\n\n" +
                    "• Controla el punto de partida y la fuerza base del modo LOG. Como el modo logarítmico simula la saturación del aire " +
                    "(donde los primeros árboles limpian mucho y luego el efecto se estabiliza), aumentar este factor potencia masivamente la eficiencia de pequeños bosques o árboles aislados por la ciudad.\n" +
                    "\nSolo funciona en modo LOG. Valor Predeterminado = 3.5" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirRootFactor)), "Factor Parabólico (Contaminación del Aire)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirRootFactor)),
                    "Seleccione el número de constante para el cálculo del modo SQRT\n\n" +
                    "• Controla la inclinación general de la curva de raíz cuadrada. " +
                    "Aumentar este valor hace que la eficiencia de los árboles crezca de forma más agresiva y lineal.\n" +
                    "Ideal para quienes buscan un término medio equilibrado donde bosques medianos limpien muy bien el aire.\n" +
                    "\nSolo funciona en modo SQRT. Valor Predeterminado = 1.5" },
            };
        }

        public void Unload() { }
    }

    // ==================== LOCALIZZAZIONE: ITALIANO (it-IT) ====================
    public class LocaleIT : IDictionarySource
    {
        private readonly Setting m_Setting;
        public LocaleIT(Setting setting) => m_Setting = setting;

        public IEnumerable<KeyValuePair<string, string>> ReadEntries(IList<IDictionaryEntryError> errors, Dictionary<string, int> indexCounts)
        {
            return new Dictionary<string, string>
            {
                { m_Setting.GetSettingsLocaleID(), "Sistema di Assorbimento tramite Alberi" },
                { m_Setting.GetOptionTabLocaleID(Setting.kSection), "Principale" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModEnabled)), "Mod Attivata" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModEnabled)), "Interruttore generale per attivare/disattivare la mod." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.UpdateInterval)), "Intervallo di Aggiornamento (Frame)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.UpdateInterval)), "Frequenza con cui le mappe vengono aggiornate (Valori più bassi pesano di più sul processore)." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.VerboseLogging)), "Registro Dettagliato (Logs)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.VerboseLogging)), "Attiva informazioni dettagliate di debug nel file di log del gioco." },

                // NOISE CONTROL (it-IT)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseReductionEnabled)), "Assorbimento Inquinamento Acustico" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseReductionEnabled)), "Attiva o disattiva il sistema di assorbimento dell'inquinamento acustico." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TreeNoiseStrength)), "Efficacia Riduzione Rumore" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TreeNoiseStrength)), "La quantità di rumore assorbita da ciascun albero (In percentuale)." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseAbsorptionRadius)), "Raggio di Azione del Rumore" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseAbsorptionRadius)), "0 = Solo cella esatta. 1-5 = Le celle vicine assorbono con attenuazione in base alla distanza." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseReductionMode)), "Modalità di Riduzione Rumore" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseReductionMode)),
                    "Seleziona il modello matematico per l'attenuazione acustica degli alberi:\n\n" +
                    "• LIN (Lineare): Riduzione fissa e costante per albero. Ideale per calcoli prevedibili, ma meno realistica.\n" +
                    "• LOG (Logaritmica): Curva basata sulla fisica reale con rendimenti decrescenti. Maggiore è il rumore, maggiore è l'efficacia iniziale di attenuazione.\n" +
                    "• SQRT (Parabolica): Attenuazione basata sulla radice quadrata. Offre un gradiente di riduzione estremamente fluido e bilanciato nelle aree circostanti." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseLogFactor)), "Fattore Logaritmico (Inquinamento Acustico)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseLogFactor)),
                    "Seleziona il valore costante per il calcolo della modalità LOG\n\n" +
                    "• Controlla il punto di partenza e l'efficacia di base della modalità LOG. Poiché la modalità logaritmica simula la saturazione del rumore " +
                    "(dove i primi alberi riducono molto e poi l'effetto si stabilizza), aumentare questo fattore potenzia massicciamente l'efficacia di piccoli boschi o alberi isolati nella città.\n" +
                    "\nFunziona solo in modalità LOG. Valore Predefinito = 1.2" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseRootFactor)), "Fattore Parabolico (Inquinamento Acustico)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseRootFactor)),
                    "Seleziona il valore costante per il calcolo della modalità SQRT\n\n" +
                    "• Controlla l'inclinazione generale della curva a radice quadrata. " +
                    "Aumentare questo valore fa sì che l'efficacia degli alberi cresca in modo più aggressivo e lineare.\n" +
                    "- Ideale per chi desidera una via di mezzo bilanciata in cui boschi di medie dimensioni attenuano molto bene il rumore.\n" +
                    "\nFunziona solo in modalità SQRT. Valore Predefinito = 1.5" },

                // AIR CONTROL (it-IT)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirReductionEnabled)), "Assorbimento Inquinamento Atmosferico" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirReductionEnabled)), "Attiva o disattiva il sistema di assorbimento dell'inquinamento atmosferico." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TreeAirStrength)), "Efficacia Purificazione dell'Aria" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TreeAirStrength)), "La quantità di inquinamento atmosferico filtrata da ciascun albero (In percentuale)." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirAbsorptionRadius)), "Raggio di Purificazione dell'Aria" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirAbsorptionRadius)), "0 = Solo cella esatta. 1-5 = Le celle vicine purificano con attenuazione in base alla distanza." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirReductionMode)), "Modalità di Purificazione dell'Aria" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirReductionMode)),
                    "Seleziona il modello matematico per il filtraggio atmosferico degli alberi:\n\n" +
                    "• LIN (Lineare): Filtraggio fisso e cumulativo per chioma. Un albero purifica sempre lo stesso valore assoluto.\n" +
                    "• LOG (Logaritmica): Modello di saturazione realistico. Simula la dispersione dei gas in cui grandi masse verdi purificano più densamente le aree critiche.\n" +
                    "• SQRT (Parabolica): Transizione matematica fluida basata su curve quadratiche, simulando meglio l'impatto diffuso di cinture verdi e venti." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirLogFactor)), "Fattore Logaritmico (Inquinamento Atmosferico)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirLogFactor)),
                    "Seleziona il valore costante per il calcolo della modalità LOG\n\n" +
                    "• Controlla il punto di partenza e l'efficacia di base della modalità LOG. Poiché la modalità logaritmica simula la saturazione dell'aria " +
                    "(dove i primi alberi puliscono molto e poi l'effetto si stabilizza), aumentare questo fattore potenzia massicciamente l'efficacia di piccoli boschi o alberi isolati nella città.\n" +
                    "\nFunziona solo in modalità LOG. Valore Predefinito = 3.5" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirRootFactor)), "Fattore Parabolico (Inquinamento Atmosferico)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirRootFactor)),
                    "Seleziona il valore costante per il calcolo della modalità SQRT\n\n" +
                    "• Controlla l'inclinazione generale della curva a radice quadrata. " +
                    "Aumentare questo valore fa sì che l'efficacia degli alberi cresca in modo più aggressivo e lineare.\n" +
                    "Ideale per chi desidera una via di mezzo bilanciata in cui boschi di medie dimensioni puliscono molto bene l'aria.\n" +
                    "\nFunziona solo in modalità SQRT. Valore Predefinito = 1.5" },
            };
        }

        public void Unload() { }
    }

    // ==================== ローカライズ: 日本語 (ja-JP) ====================
    public class LocaleJA : IDictionarySource
    {
        private readonly Setting m_Setting;
        public LocaleJA(Setting setting) => m_Setting = setting;

        public IEnumerable<KeyValuePair<string, string>> ReadEntries(IList<IDictionaryEntryError> errors, Dictionary<string, int> indexCounts)
        {
            return new Dictionary<string, string>
            {
                { m_Setting.GetSettingsLocaleID(), "樹木汚染吸収システム" },
                { m_Setting.GetOptionTabLocaleID(Setting.kSection), "メイン" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModEnabled)), "Mod有効" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModEnabled)), "Mod全体の有効/無効を切り替えるマスターキーです。" },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.UpdateInterval)), "更新間隔 (フレーム)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.UpdateInterval)), "マップが更新される頻度です (値を小さくすると、プロセッサへの負荷が高くなります)。" },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.VerboseLogging)), "詳細ログの記録" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.VerboseLogging)), "ゲームのログファイルに詳細なデバッグ情報を出力します。" },

                // NOISE CONTROL (ja-JP)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseReductionEnabled)), "騒音汚染の吸収" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseReductionEnabled)), "騒音汚染の吸収システムを有効または無効にします。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TreeNoiseStrength)), "騒音低減の強度" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TreeNoiseStrength)), "各樹木が吸収する騒音の量 (パーセンテージ) です。" },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseAbsorptionRadius)), "騒音吸収の範囲" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseAbsorptionRadius)), "0 = 正確なセルのみ。1-5 = 周辺のセルが距離減衰を伴って吸収します。" },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseReductionMode)), "騒音低減モード" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseReductionMode)),
                    "樹木の騒音減衰に使用する数学的モデルを選択します:\n\n" +
                    "• LIN (線形): 樹木ごとに固定かつ一定の低減を行います。計算が予測しやすい反面、リアルさは劣ります。\n" +
                    "• LOG (対数): 収穫逓減を伴う実際の物理に基づいた曲線です。騒音レベルが高いほど、初期の減衰効率が高くなります。\n" +
                    "• SQRT (放物線): 平方根に基づいた減衰です。周辺地域において、極めて滑らかでバランスの取れた低減グラデーションを提供します。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseLogFactor)), "対数係数 (騒音汚染)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseLogFactor)),
                    "LOGモードの計算に使用する定数を選択します\n\n" +
                    "• LOGモードの開始点と基本強度を制御します。対数モードは音の飽和をシミュレートするため " +
                    "(最初の数本の樹木が大幅にクリアし、その後効果が安定する)、この係数を上げると、街の小さな木立ちや孤立した樹木の効率が大幅に向上します。\n" +
                    "\nLOGモードでのみ機能します。デフォルト値 = 1.2" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseRootFactor)), "放物線係数 (騒音汚染)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseRootFactor)),
                    "SQRTモードの計算に使用する定数を選択します\n\n" +
                    "• 平方根曲線の全体的な傾きを制御します。" +
                    "この値を大きくすると、樹木の効率がより積極的に、かつ線形に近い形で成長します。\n" +
                    "- 中規模の森林で騒音をしっかりと抑えたい、バランスの取れた中間的なアプローチを求める方に最適です。\n" +
                    "\nSQRTモードでのみ機能します。デフォルト値 = 1.5" },

                // AIR CONTROL (ja-JP)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirReductionEnabled)), "大気汚染の吸収" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirReductionEnabled)), "大気汚染の吸収システムを有効または無効にします。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TreeAirStrength)), "大気浄化の強度" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TreeAirStrength)), "各樹木がろ過する大気汚染の量 (パーセンテージ) です。" },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirAbsorptionRadius)), "大気浄化の範囲" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirAbsorptionRadius)), "0 = 正確なセルのみ。1-5 = 周辺のセルが距離減衰を伴って浄化します。" },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirReductionMode)), "大気浄化モード" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirReductionMode)),
                    "樹木の大気ろ過に使用する数学的モデルを選択します:\n\n" +
                    "• LIN (線形): 樹冠ごとの固定かつ累積的なろ過です。1本の樹木は常に同じ絶対値を浄化します。\n" +
                    "• LOG (対数): リアルな飽和モデルです。大規模な緑地が深刻な地域の汚染をより濃密に浄化する、ガスの拡散をシミュレートします。\n" +
                    "• SQRT (放物線): 二次曲線に基づいた滑らかな数学的遷移であり、グリーンベルトや風による拡散の影響をより適切にシミュレートします。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirLogFactor)), "対数係数 (大気汚染)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirLogFactor)),
                    "LOGモードの計算に使用する定数を選択します\n\n" +
                    "• LOGモードの開始点と基本強度を制御します。対数モードは大気の飽和をシミュレートするため " +
                    "(最初の数本の樹木が大幅にクリアし、その後効果が安定する)、この係数を上げると、街の小さな木立ちや孤立した樹木の効率が大幅に向上します。\n" +
                    "\nLOGモードでのみ機能します。デフォルト値 = 3.5" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirRootFactor)), "放物線係数 (大気汚染)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirRootFactor)),
                    "SQRTモードの計算に使用する定数を選択します\n\n" +
                    "• 平方根曲線の全体的な傾きを制御します。" +
                    "この値を大きくすると、樹木の効率がより積極的に、かつ線形に近い形で成長します。\n" +
                    "中規模の森林で大気をしっかりと浄化したい、バランスの取れた中間的なアプローチを求める方に最適です。\n" +
                    "\nSQRTモードでのみ機能します。デフォルト値 = 1.5" },
            };
        }

        public void Unload() { }
    }

    // ==================== 로컬라이징: 한국어 (ko-KR) ====================
    public class LocaleKO : IDictionarySource
    {
        private readonly Setting m_Setting;
        public LocaleKO(Setting setting) => m_Setting = setting;

        public IEnumerable<KeyValuePair<string, string>> ReadEntries(IList<IDictionaryEntryError> errors, Dictionary<string, int> indexCounts)
        {
            return new Dictionary<string, string>
            {
                { m_Setting.GetSettingsLocaleID(), "나무 오염 흡수 시스템" },
                { m_Setting.GetOptionTabLocaleID(Setting.kSection), "기본" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModEnabled)), "모드 활성화" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModEnabled)), "모드 전체를 켜거나 끄는 마스터 스위치입니다." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.UpdateInterval)), "업데이트 간격 (프레임)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.UpdateInterval)), "지도가 업데이트되는 빈도입니다 (값이 작을수록 프로세서에 가해지는 부담이 커집니다)." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.VerboseLogging)), "상세 로그 기록" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.VerboseLogging)), "게임 로그 파일에 상세한 디버깅 정보를 활성화합니다." },

                // NOISE CONTROL (ko-KR)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseReductionEnabled)), "소음 공해 흡수" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseReductionEnabled)), "소음 공해 흡수 시스템을 활성화하거나 비활성화합니다." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TreeNoiseStrength)), "소음 감소 강도" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TreeNoiseStrength)), "각 나무가 흡수하는 소음의 양 (백분율) 입니다." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseAbsorptionRadius)), "소음 흡수 반경" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseAbsorptionRadius)), "0 = 정확한 셀만 해당. 1-5 = 주변 셀이 거리에 따른 감쇠를 적용하여 흡수합니다." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseReductionMode)), "소음 감소 모드" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseReductionMode)),
                    "나무의 소음 감쇠에 사용할 수학적 모델을 선택하세요:\n\n" +
                    "• LIN (선형): 나무당 고정되고 일정한 감소량을 적용합니다. 예측 가능한 계산에 이상적이지만 현실성은 떨어집니다.\n" +
                    "• LOG (로그): 수확 체감 법칙이 적용된 실제 물리 기반 곡선입니다. 소음이 심할수록 초기 감쇠 효율이 높아집니다.\n" +
                    "• SQRT (포물선): 제곱근에 기반한 감쇠입니다. 주변 지역에 극도로 부드럽고 균형 잡힌 감소 그래디언트를 제공합니다." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseLogFactor)), "로그 계수 (소음 공해)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseLogFactor)),
                    "LOG 모드 계산에 사용할 상수 값을 선택하세요\n\n" +
                    "• LOG 모드의 시작점과 기본 강도를 제어합니다. 로그 모드는 소음의 포화를 시뮬레이션하므로 " +
                    "(처음 몇 그루의 나무가 크게 청소하고 이후 효과가 안정됨), 이 계수를 높이면 도시의 작은 숲이나 고립된 나무의 효율이 대폭 향상됩니다.\n" +
                    "\nLOG 모드에서만 작동합니다. 기본값 = 1.2" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseRootFactor)), "포물선 계수 (소음 공해)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseRootFactor)),
                    "SQRT 모드 계산에 사용할 상수 값을 선택하세요\n\n" +
                    "• 제곱근 곡선의 전체적인 기울기를 제어합니다. " +
                    "이 값을 높이면 나무의 효율이 더욱 공격적이고 선형에 가깝게 성장합니다.\n" +
                    "- 중소규모의 숲에서 소음을 확실하게 차단하고 싶은, 균형 잡힌 중간 지점을 원하는 분들에게 이상적입니다.\n" +
                    "\nSQRT 모드에서만 작동합니다. 기본값 = 1.5" },

                // AIR CONTROL (ko-KR)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirReductionEnabled)), "대기 공해 흡수" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirReductionEnabled)), "대기 공해 흡수 시스템을 활성화하거나 비활성화합니다." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TreeAirStrength)), "대기 정화 강도" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TreeAirStrength)), "각 나무가 필터링하는 대기 공해의 양 (백분율) 입니다." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirAbsorptionRadius)), "대기 정화 반경" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirAbsorptionRadius)), "0 = 정확한 셀만 해당. 1-5 = 주변 셀이 거리에 따른 감쇠를 적용하여 정화합니다." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirReductionMode)), "대기 정화 모드" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirReductionMode)),
                    "나무의 대기 필터링에 사용할 수학적 모델을 선택하세요:\n\n" +
                    "• LIN (선형): 캐노피(수관)당 고정되고 누적되는 필터링입니다. 나무 한 그루는 항상 동일한 절대값을 정화합니다.\n" +
                    "• LOG (로그): 현실적인 포화 모델입니다. 거대한 녹지가 심각한 지역의 오염을 더 집중적으로 정화하는 가스 확산을 시뮬레이션합니다.\n" +
                    "• SQRT (포물선): 이차 곡선에 기반한 부드러운 수학적 전이로, 녹지대 및 바람에 의한 확산 영향을 더 잘 시뮬레이션합니다." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirLogFactor)), "로그 계수 (대기 공해)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirLogFactor)),
                    "LOG 모드 계산에 사용할 상수 값을 선택하세요\n\n" +
                    "• LOG 모드의 시작점과 기본 강도를 제어합니다. 로그 모드는 대기의 포화를 시뮬레이션하므로 " +
                    "(처음 몇 그루의 나무가 크게 청소하고 이후 효과가 안정됨), 이 계수를 높이면 도시의 작은 숲이나 고립된 나무의 효율이 대폭 향상됩니다.\n" +
                    "\nLOG 모드에서만 작동합니다. 기본값 = 3.5" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirRootFactor)), "포물선 계수 (대기 공해)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirRootFactor)),
                    "SQRT 모드 계산에 사용할 상수 값을 선택하세요\n\n" +
                    "• 제곱근 곡선의 전체적인 기울기를 제어합니다. " +
                    "이 값을 높이면 나무의 효율이 더욱 공격적이고 선형에 가깝게 성장합니다.\n" +
                    "중소규모의 숲에서 대기를 확실하게 정화하고 싶은, 균형 잡힌 중간 지점을 원하는 분들에게 이상적입니다.\n" +
                    "\nSQRT 모드에서만 작동합니다. 기본값 = 1.5" },
            };
        }

        public void Unload() { }
    }

    // ==================== LOCALIZAÇÃO: CHINÊS (zh-CN) ====================
    public class LocaleZH : IDictionarySource
    {
        private readonly Setting m_Setting;
        public LocaleZH(Setting setting) => m_Setting = setting;

        public IEnumerable<KeyValuePair<string, string>> ReadEntries(IList<IDictionaryEntryError> errors, Dictionary<string, int> indexCounts)
        {
            return new Dictionary<string, string>
            {
                { m_Setting.GetSettingsLocaleID(), "树木吸收系统" },
                { m_Setting.GetOptionTabLocaleID(Setting.kSection), "常规" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModEnabled)), "启用 Mod" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModEnabled)), "启用或禁用树木对周边环境的污染吸收逻辑。" },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.UpdateInterval)), "更新频率 (帧)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.UpdateInterval)), "污染地图更新的帧数间隔（数值越低越平滑，但会增加 CPU 负担）。" },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.VerboseLogging)), "详细日志记录" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.VerboseLogging)), "在游戏日志文件中记录详细的调试信息。" },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseReductionEnabled)), "噪音污染吸收" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseReductionEnabled)), "启用或禁用噪音污染吸收系统。" },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirReductionEnabled)), "空气污染吸收" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirReductionEnabled)), "启用或禁用空气污染吸收系统。" },

                // NOISE CONTROL (zh-Hans)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TreeNoiseStrength)), "噪音消减强度" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TreeNoiseStrength)), "每棵树木吸收噪音的比例。" },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseAbsorptionRadius)), "噪音吸收半径" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseAbsorptionRadius)), "0 = 仅限当前网格。1-5 = 周边网格吸收并伴随距离衰减。" },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseReductionMode)), "噪音消减模式" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseReductionMode)),
                    "选择树木噪音衰减的数学模型：\n\n" +
                    "• LIN (线性)：每棵树固定的恒定消减量。便于预测计算，但略欠真实性。\n" +
                    "• LOG (对数)：基于真实物理的收益递减曲线。噪音水平越高，初始衰减效果越强。\n" +
                    "• SQRT (抛物线)：基于平方根的衰减模式。在周边网格间提供极度平滑且均衡的消减过渡。" },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseLogFactor)), "对数因子 (噪音污染)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseLogFactor)),
                    "选择对数(LOG)模式计算的常数值。\n\n" +
                    "• 控制对数模式的起点和基础强度。由于对数模式模拟了声音饱和效应" +
                    "（即最初的几棵树能吸收大量噪音，随后效果趋于平缓），提高该因子将大幅提升城市中小型树丛或独立树木的降噪效率。\n" +
                    "\n仅在对数(LOG)模式下生效。默认值 = 1.2" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseRootFactor)), "抛物线因子 (噪音污染)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseRootFactor)),
                    "选择平方根(SQRT)模式计算的常数值。\n\n" +
                    "• 控制平方根曲线 generalized 的整体倾斜度。\n" +
                    "提高该值会使树木的效率增长得更具侵略性且更接近线性。\n" +
                    "非常适合追求平衡的玩家，使中等规模的森林就能非常有效地吸收噪音。\n" +
                    "\n仅在平方根(SQRT)模式下生效。默认值 = 1.5" },

                // AIR CONTROL (zh-Hans)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TreeAirStrength)), "空气净化强度" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TreeAirStrength)), "每棵树木过滤空气污染的比例。" },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirAbsorptionRadius)), "空气净化半径" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirAbsorptionRadius)), "0 = 仅限当前网格。1-5 = 周边网格净化并伴随距离衰减。" },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirReductionMode)), "空气净化模式" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirReductionMode)),
                    "选择树木大气过滤的数学模型：\n\n" +
                    "• LIN (线性)：每棵树冠固定且累加的净化值。树木过滤的绝对值始终保持不变。\n" +
                    "• LOG (对数)：真实的饱和度模型。模拟气体扩散，使大型绿化带能够更高效地净化核心污染源。\n" +
                    "• SQRT (抛物线)：基于二次曲线的平滑数学过渡，能更真实地模拟防风林带对空气造成的扩散式影响。" },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirLogFactor)), "对数因子 (噪音污染)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirLogFactor)),
                    "选择对数(LOG)模式计算的常数值。\n\n" +
                    "• 控制对数模式的起点和基础强度。由于对数模式模拟了声音饱和效应" +
                    "（即最初的几棵树能吸收大量噪音，随后效果趋于平缓），提高该因子将大幅提升城市中小型树丛或独立树木的降噪效率。\n" +
                    "\n仅在对数(LOG)模式下生效。默认值 = 1.2" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirRootFactor)), "抛物线因子 (噪音污染)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirRootFactor)),
                    "选择平方根(SQRT)模式计算的常数值。\n\n" +
                    "• 控制平方根曲线 generalized 的整体倾斜度。\n" +
                    "提高该值会使树木的效率增长得更具侵略性且更接近线性。\n" +
                    "非常适合追求平衡的玩家，使中等规模的森林就能非常有效地吸收噪音。\n" +
                    "\n仅在平方根(SQRT)模式下生效。默认值 = 1.5" },
            };
        }
        public void Unload() { }
    }

    // ==================== LOKALIZACJA: JĘZYK POLSKI (pl-PL) ====================
    public class LocalePL : IDictionarySource
    {
        private readonly Setting m_Setting;
        public LocalePL(Setting setting) => m_Setting = setting;

        public IEnumerable<KeyValuePair<string, string>> ReadEntries(IList<IDictionaryEntryError> errors, Dictionary<string, int> indexCounts)
        {
            return new Dictionary<string, string>
            {
                { m_Setting.GetSettingsLocaleID(), "System absorpcji zanieczyszczeń przez drzewa" },
                { m_Setting.GetOptionTabLocaleID(Setting.kSection), "Główny" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModEnabled)), "Mod włączony" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModEnabled)), "Główny przełącznik do włączania/wyłączania modyfikacji." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.UpdateInterval)), "Interwał aktualizacji (Klatki)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.UpdateInterval)), "Częstotliwość aktualizacji map (Niższe wartości bardziej obciążają procesor)." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.VerboseLogging)), "Szczegółowe logowanie (Logs)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.VerboseLogging)), "Włącza szczegółowe informacje debugowania w pliku logu gry." },

                // NOISE CONTROL (pl-PL)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseReductionEnabled)), "Absorpcja hałasu" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseReductionEnabled)), "Włącza lub wyłącza system absorpcji zanieczyszczenia hałasem." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TreeNoiseStrength)), "Siła redukcji hałasu" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TreeNoiseStrength)), "Ilość hałasu pochłaniana przez każde drzewo (W procentach)." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseAbsorptionRadius)), "Promień tłumienia hałasu" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseAbsorptionRadius)), "0 = Tylko dokładna komórka. 1-5 = Sąsiednie komórki absorbują hałas z tłumieniem odległościowym." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseReductionMode)), "Tryb redukcji hałasu" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseReductionMode)),
                    "Wybierz model matematyczny dla tłumienia hałasu przez drzewa:\n\n" +
                    "• LIN (Liniowy): Stała i niezmienna redukcja na jedno drzewo. Idealna dla przewidywalnych obliczeń, ale mniej realistyczna.\n" +
                    "• LOG (Logarytmiczny): Krzywa oparta na realnej fizyce z malejącymi efektami krańcowymi. Im większy hałas, tym wyższa początkowa efektywność tłumienia.\n" +
                    "• SQRT (Paraboliczny): Tłumienie oparte na pierwiastku kwadratowym. Oferuje niezwykle płynny i zrównoważony gradient redukcji w okolicy." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseLogFactor)), "Współczynnik logarytmiczny (Hałas)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseLogFactor)),
                    "Wybierz wartość stałej dla obliczeń w trybie LOG\n\n" +
                    "• Kontroluje punkt startowy i bazową siłę trybu LOG. Ponieważ tryb logarytmiczny symuluje nasycenie dźwięku " +
                    "(gdzie pierwsze drzewa tłumią bardzo dużo, a potem efekt się stabilizuje), zwiększenie tego czynnika masowo zwiększa efektywność małych zagajników lub pojedynczych drzew w mieście.\n" +
                    "\nDziała tylko w trybie LOG. Wartość domyślna = 1.2" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseRootFactor)), "Współczynnik paraboliczny (Hałas)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseRootFactor)),
                    "Wybierz wartość stałej dla obliczeń w trybie SQRT\n\n" +
                    "• Kontroluje ogólne nachylenie krzywej pierwiastka kwadratowego. " +
                    "Zwiększenie tej wartości sprawia, że efektywność drzew rośnie w sposób bardziej agresywny i zbliżony do liniowego.\n" +
                    "- Idealne dla osób szukających zrównoważonego kompromisu, gdzie średnie lasy bardzo dobrze tłumią hałas.\n" +
                    "\nDziała tylko w trybie SQRT. Wartość domyślna = 1.5" },

                // AIR CONTROL (pl-PL)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirReductionEnabled)), "Absorpcja zanieczyszczeń powietrza" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirReductionEnabled)), "Włącza lub wyłącza system absorpcji zanieczyszczeń powietrza." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TreeAirStrength)), "Siła oczyszczania powietrza" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TreeAirStrength)), "Ilość zanieczyszczeń powietrza filtrowana przez każde drzewo (W procentach)." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirAbsorptionRadius)), "Promień oczyszczania powietrza" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirAbsorptionRadius)), "0 = Tylko dokładna komórka. 1-5 = Sąsiednie komórki oczyszczają z tłumieniem odległościowym." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirReductionMode)), "Tryb oczyszczania powietrza" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirReductionMode)),
                    "Wybierz model matematyczny dla filtracji atmosferycznej przez drzewa:\n\n" +
                    "• LIN (Liniowy): Stała i sumująca się filtracja na każdą koronę drzewa. Jedno drzewo zawsze oczyszcza tę samą wartość absolutną.\n" +
                    "• LOG (Logarytmiczny): Realistyczny model nasycenia. Symuluje rozproszenie gazów, gdzie duże obszary zielone intensywniej oczyszczają krytyczne strefy.\n" +
                    "• SQRT (Paraboliczny): Płynne przejście matematyczne oparte na krzywych kwadratowych, lepiej symulujące rozproszony wpływ pasów zieleni i wiatrów." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirLogFactor)), "Współczynnik logarytmiczny (Powietrze)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirLogFactor)),
                    "Wybierz wartość stałej dla obliczeń w trybie LOG\n\n" +
                    "• Kontroluje punkt startowy i bazową siłę trybu LOG. Ponieważ tryb logarytmiczny symuluje nasycenie powietrza " +
                    "(gdzie pierwsze drzewa oczyszczają bardzo dużo, a potem efekt się stabilizuje), zwiększenie tego czynnika masowo zwiększa efektywność małych zagajników lub pojedynczych drzew w mieście.\n" +
                    "\nDziała tylko w trybie LOG. Wartość domyślna = 3.5" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirRootFactor)), "Współczynnik paraboliczny (Powietrze)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirRootFactor)),
                    "Wybierz wartość stałej dla obliczeń w trybie SQRT\n\n" +
                    "• Kontroluje ogólne nachylenie krzywej pierwiastka kwadratowego. " +
                    "Zwiększenie tej wartości sprawia, że efektywność drzew rośnie w sposób bardziej agresywny i zbliżony do liniowego.\n" +
                    "Idealne dla osób szukających zrównoważonego kompromisu, gdzie średnie lasy bardzo dobrze oczyszczają powietrze.\n" +
                    "\nDziała tylko w trybie SQRT. Wartość domyślna = 1.5" },
            };
        }

        public void Unload() { }
    }

    // ==================== ЛОКАЛИЗАЦИЯ: РУССКИЙ ЯЗЫК (ru-RU) ====================
    public class LocaleRU : IDictionarySource
    {
        private readonly Setting m_Setting;
        public LocaleRU(Setting setting) => m_Setting = setting;

        public IEnumerable<KeyValuePair<string, string>> ReadEntries(IList<IDictionaryEntryError> errors, Dictionary<string, int> indexCounts)
        {
            return new Dictionary<string, string>
            {
                { m_Setting.GetSettingsLocaleID(), "Система поглощения загрязнений деревьями" },
                { m_Setting.GetOptionTabLocaleID(Setting.kSection), "Главная" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModEnabled)), "Мод включен" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModEnabled)), "Главный переключатель для включения/выключения мода." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.UpdateInterval)), "Интервал обновления (Кадры)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.UpdateInterval)), "Частота обновления карт (Меньшие значения увеличивают нагрузку на процессор)." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.VerboseLogging)), "Подробное логирование (Logs)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.VerboseLogging)), "Включает подробную отладочную информацию в лог-файл игры." },

                // NOISE CONTROL (ru-RU)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseReductionEnabled)), "Поглощение шумового загрязнения" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseReductionEnabled)), "Включает или выключает систему поглощения шумового загрязнения." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TreeNoiseStrength)), "Эффективность снижения шума" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TreeNoiseStrength)), "Количество шума, поглощаемое каждым деревом (В процентах)." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseAbsorptionRadius)), "Радиус поглощения шума" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseAbsorptionRadius)), "0 = Только точная ячейка. 1-5 = Соседние ячейки поглощают шум с затуханием в зависимости от расстояния." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseReductionMode)), "Режим снижения шума" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseReductionMode)),
                    "Выберите математическую модель для затухания шума деревьями:\n\n" +
                    "• LIN (Линейная): Фиксированное и постоянное снижение на одно дерево. Идеально для предсказуемых расчетов, но менее реалистично.\n" +
                    "• LOG (Логарифмическая): Кривая на основе реальной физики с убывающей эффективностью. Чем выше уровень шума, тем выше начальная эффективность затухания.\n" +
                    "• SQRT (Параболическая): Затухание на основе квадратного корня. Обеспечивает исключительно плавный и сбалансированный градиент снижения шума в окрестностях." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseLogFactor)), "Логарифмический коэффициент (Шум)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseLogFactor)),
                    "Выберите значение константы для расчетов в режиме LOG\n\n" +
                    "• Управляет стартовой точкой и базовой силой режима LOG. Поскольку логарифмический режим симулирует насыщение звука " +
                    "(где первые несколько деревьев глушат много шума, а затем эффект стабилизируется), увеличение этого фактора значительно повышает эффективность небольших рощ или одиночных деревьев в городе.\n" +
                    "\nРаботает только в режиме LOG. Значение по умолчанию = 1.2" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseRootFactor)), "Параболический коэффициент (Шум)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseRootFactor)),
                    "Выберите значение константы для расчетов в режиме SQRT\n\n" +
                    "• Управляет общим наклоном кривой квадратного корня. " +
                    "Увеличение этого значения заставляет эффективность деревьев расти более агрессивно и линейно.\n" +
                    "- Идеально для тех, кто ищет сбалансированный компромисс, при котором средние лесные массивы очень хорошо глушат шум.\n" +
                    "\nРаботает только в режиме SQRT. Значение по умолчанию = 1.5" },

                // AIR CONTROL (ru-RU)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirReductionEnabled)), "Поглощение загрязнения воздуха" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirReductionEnabled)), "Включает или выключает систему поглощения загрязнения воздуха." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TreeAirStrength)), "Эффективность очистки воздуха" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TreeAirStrength)), "Количество загрязнения воздуха, фильтруемое каждым деревом (В процентах)." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirAbsorptionRadius)), "Радиус очистки воздуха" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirAbsorptionRadius)), "0 = Только точная ячейка. 1-5 = Соседние ячейки очищают воздух с затуханием в зависимости от расстояния." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirReductionMode)), "Режим очистки воздуха" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirReductionMode)),
                    "Выберите математическую модель для атмосферной фильтрации деревьями:\n\n" +
                    "• LIN (Линейная): Фиксированная и кумулятивная фильтрация на каждую крону. Одно дерево всегда очищает одно и то же абсолютное значение.\n" +
                    "• LOG (Логарифмическая): Реалистичная модель насыщения. Симулирует рассеивание газов, при котором крупные зеленые массивы более плотно очищают критические зоны.\n" +
                    "• SQRT (Параболическая): Плавный математический переход на основе квадратичных кривых, лучше симулирующий диффузное воздействие зеленых поясов и ветров." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirLogFactor)), "Логарифмический коэффициент (Воздух)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirLogFactor)),
                    "Выберите значение константы для расчетов в режиме LOG\n\n" +
                    "• Управляет стартовой точкой и базовой силой режима LOG. Поскольку логарифмический режим симулирует насыщение воздуха " +
                    "(где первые несколько деревьев очищают много воздуха, а затем эффект стабилизируется), увеличение этого фактора значительно повышает эффективность небольших рощ или одиночных деревьев в городе.\n" +
                    "\nРаботает только в режиме LOG. Значение по умолчанию = 3.5" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirRootFactor)), "Параболический коэффициент (Воздух)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirRootFactor)),
                    "Выберите значение константы для расчетов в режиме SQRT\n\n" +
                    "• Управляет общим наклоном кривой квадратного корня. " +
                    "Увеличение этого значения заставляет эффективность деревьев расти более агрессивно и линейно.\n" +
                    "Идеально для тех, кто ищет сбалансированный компромисс, при котором средние лесные массивы очень хорошо очищают воздух.\n" +
                    "\nРаботает только в режиме SQRT. Значение по умолчанию = 1.5" },
            };
        }

        public void Unload() { }
    }

}

