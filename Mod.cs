using Colossal.Logging;
using Colossal.IO.AssetDatabase;
using Colossal.Localization;
using Game;
using Game.Modding;
using Game.SceneFlow;

namespace ArvoreAbsorptionSystem
{
    public class Mod : IMod
    {
        public static ILog log = LogManager.GetLogger($"{nameof(ArvoreAbsorptionSystem)}").SetShowsErrorsInUI(false);
        public static Setting m_Setting;

        public void OnLoad(UpdateSystem updateSystem)
        {
            log.Info(nameof(OnLoad));

            if (m_Setting == null)
            {
                m_Setting = new Setting(this);
            }

            m_Setting.RegisterInOptionsUI();
            GameManager.instance.localizationManager.AddSource("en-US", new LocaleEN(m_Setting));
            GameManager.instance.localizationManager.AddSource("pt-BR", new LocalePT(m_Setting));
            GameManager.instance.localizationManager.AddSource("de-DE", new LocaleDE(m_Setting));
            GameManager.instance.localizationManager.AddSource("fr-FR", new LocaleFR(m_Setting));
            GameManager.instance.localizationManager.AddSource("zh-Hans", new LocaleZH(m_Setting));

            // Fixed: AssetDatabase now resolves with the added using statement
            AssetDatabase.global.LoadSettings(nameof(ArvoreAbsorptionSystem), m_Setting, new Setting(this));

            updateSystem.UpdateAt<ArvoreAbsorptionSystem>(SystemUpdatePhase.GameSimulation);
        }

        public void OnDispose()
        {
            log.Info(nameof(OnDispose));
            if (m_Setting != null)
            {
                m_Setting.UnregisterInOptionsUI();
                m_Setting = null;
            }
        }
    }
}