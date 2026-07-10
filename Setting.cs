using System.Collections.Generic;
using Colossal;
using Colossal.IO.AssetDatabase;
using Game.Modding;
using Game.Prefabs.Modes;
using Game.Settings;
using Game.UI;
using Game.UI.Widgets;

namespace ArvoreAbsorptionSystem
{
    [FileLocation(nameof(ArvoreAbsorptionSystem))]
    public class Setting : ModSetting
    {
        public const string kSection = "Main";

        public Setting(IMod mod) : base(mod)
        {
        }

        [SettingsUISection(kSection, "General")]
        public bool ModEnabled { get; set; } = true;

        [SettingsUISlider(min = 16, max = 512, step = 16)]
        [SettingsUISection(kSection, "General")]
        public int UpdateInterval { get; set; } = 128;

        [SettingsUISection(kSection, "General")]
        public bool VerboseLogging { get; set; } = false;

        // ================= NOISE POLLUTION CONTROLS =================
        [SettingsUISection(kSection, "Noise Enabled")]
        public bool NoiseReductionEnabled { get; set; } = true;
        
        [SettingsUISlider(min = 0, max = 500, step = 1, unit = Unit.kPercentage)]
        [SettingsUISection(kSection, "Noise Reduction")]
        public int TreeNoiseStrength { get; set; } = 25;

        [SettingsUISlider(min = 0, max = 5, step = 1)]
        [SettingsUISection(kSection, "Noise Reduction")]
        public int NoiseAbsorptionRadius { get; set; } = 1;

        [SettingsUIDropdown(typeof(Setting), nameof(GetModeItems))]
        [SettingsUISection(kSection, "Noise Reduction")]
        public int NoiseReductionMode { get; set; } = 0;

        [SettingsUISlider(min = 1.0f, max = 6.0f, step = 0.1f, unit = Unit.kFloatTwoFractions)]
        [SettingsUISection(kSection, "Noise Reduction")]
        public float NoiseLogFactor { get; set; } = 1.2f;
        
        [SettingsUISlider(min = 1.0f, max = 3.0f, step = 0.1f, unit = Unit.kFloatTwoFractions)]
        [SettingsUISection(kSection, "Noise Reduction")]
        public float NoiseRootFactor { get; set; } = 1.5f;

        // ================= AIR POLLUTION CONTROLS =================
        [SettingsUISection(kSection, "Air Enabled")]
        public bool AirReductionEnabled { get; set; } = true;

        [SettingsUISlider(min = 0, max = 500, step = 1, unit = Unit.kPercentage)]
        [SettingsUISection(kSection, "Air Purification")]
        public int TreeAirStrength { get; set; } = 25;

        [SettingsUISlider(min = 0, max = 5, step = 1)]
        [SettingsUISection(kSection, "Air Purification")]
        public int AirAbsorptionRadius { get; set; } = 1;

        [SettingsUIDropdown(typeof(Setting), nameof(GetModeItems))]
        [SettingsUISection(kSection, "Air Purification")]
        public int AirReductionMode { get; set; } = 0;

        [SettingsUISlider(min = 1.0f, max = 6.0f, step = 0.1f, unit = Unit.kFloatTwoFractions)]
        [SettingsUISection(kSection, "Air Purification")]
        public float AirLogFactor { get; set; } = 3.5f;

        [SettingsUISlider(min = 1.0f, max = 3.0f, step = 0.1f, unit = Unit.kFloatTwoFractions)]
        [SettingsUISection(kSection, "Air Purification")]
        public float AirRootFactor { get; set; } = 1.5f;



        
        public DropdownItem<int>[] GetModeItems()
        {
            return new[]
            {
                new DropdownItem<int> { value = 0, displayName = "LIN" },
                new DropdownItem<int> { value = 1, displayName = "LOG" },
                new DropdownItem<int> { value = 2, displayName = "SQRT" }
            };
        }

        public override void SetDefaults()
        {
            ModEnabled = true;
            UpdateInterval = 128;
            VerboseLogging = false;

            TreeNoiseStrength = 25;
            NoiseAbsorptionRadius = 1;
            NoiseReductionMode = 0;

            TreeAirStrength = 20;
            AirAbsorptionRadius = 1;
            AirReductionMode = 0;
        }
    }
}