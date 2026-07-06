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
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModEnabled)), "Ativa ou desativa o sistema de absorção ambiental para todas as árvores." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.UpdateInterval)), "Intervalo de Atualização (Frames)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.UpdateInterval)), "Frequência com que os mapas são atualizados (Valores menores pesam mais no processador)." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.VerboseLogging)), "Registro Detalhado (Logs)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.VerboseLogging)), "Ativa informações detalhadas de depuração no arquivo de log do jogo." },

                // NOISE CONTROL (pt-BR)
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

    // ==================== LOCALIZAÇÃO: FRANCÊS (fr-FR) ====================
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
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.UpdateInterval)), "Fréquence de mise à jour en images (Plus bas est mais fluide, mais sollicite le processeur)." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.VerboseLogging)), "Journalisation détaillée" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.VerboseLogging)), "Active les informations de débogage détaillées dans le fichier journal." },

                // NOISE CONTROL (fr-FR)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TreeNoiseStrength)), "Force de réduction du bruit" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TreeNoiseStrength)), "Quantité de bruit absorbée par chaque arbre." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseAbsorptionRadius)), "Rayon de captation du bruit" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseAbsorptionRadius)), "0 = Cellule exacte uniquement. 1-5 = Les cellules voisines absorbent avec atténuation." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.NoiseReductionMode)), "Mode de réduction du bruit" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirReductionMode)),
                    "Sélectionnez le modèle mathématique pour la filtration atmosphérique des arbres :\n\n" +
                    "• LIN (Linéaire) : Purification fixe et cumulative par canopée. Chaque arbre filtre toujours la même valeur absolue.\n" +
                    "• LOG (Logarithmique) : Modèle de saturation réaliste. Simule la dispersion des gaz où les grandes masses vertes purifient plus densément les zones critiques.\n" +
                    "• SQRT (Parabolique) : Transition mathématique fluide basée sur des courbes quadratiques, simulant mieux l'impact diffus des ceintures vertes." },
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

                // AIR CONTROL (fr-FR)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TreeAirStrength)), "Force de purification de l'air" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TreeAirStrength)), "Quantité de pollution de l'air filtrée par chaque arbre." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirAbsorptionRadius)), "Rayon de purification de l'air" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.AirAbsorptionRadius)), "0 = Cellule exacte uniquement. 1-5 = Les cellules voisines purifient avec atténuation." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.AirReductionMode)), "Mode de purification de l'air" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.NoiseReductionMode)),
                    "Sélectionnez le modèle mathématique pour l'atténuation acoustique des arbres :\n\n" +
                    "• LIN (Linéaire) : Réduction fixe et constante par arbre. Idéal pour des calculs prévisibles, mais moins réaliste.\n" +
                    "• LOG (Logarithmique) : Courbe physique avec rendements décroissants. Un niveau de bruit plus élevé déclenche une atténuation initiale plus forte.\n" +
                    "• SQRT (Parabolique) : Atténuation basée sur la racine carrée. Offre un gradient de réduction extrêmement fluide et équilibré dans le voisinage." },
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

    // ==================== LOCALIZAÇÃO: CHINÊS (zh-Hans) ====================
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
            };
        }
        public void Unload() { }
    }
}