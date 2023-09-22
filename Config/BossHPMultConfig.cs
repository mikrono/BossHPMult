using MonoMod.Utils;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader.Config;
using System.Linq;

namespace BossHPMult.Config
{
    internal class BossHPMultConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;


        [Header("GlobalNPCSettings")]

        [DefaultValue(1)]
        [Range(1, 1000)]
        public int BHealthMultiplierValue;

        [DefaultValue(1)]
        [Range(1, 1000)]
        public int BDamageMultiplierValue;

        [DefaultValue(1)]
        [Range(1, 10)]
        public int BSizeMultiplierValue;

        [Header("SpecificNPCSettings")]

        public Dictionary<BossDefinition, BossEntry> BossSettings
        {
            get
            {
                return BHMState.SettingPairs;
            }
            set
            {
                var oldPairs = BHMState.SettingPairs;
                if (value == null)
                {
                    BHMState.SettingPairs = BHMState.InitValues();
                    return;
                }
                foreach (var pair in value)
                {
                    if (oldPairs.ContainsKey(pair.Key) || oldPairs[pair.Key] != value[pair.Key])
                    {
                        BHMState.SettingPairs[pair.Key] = pair.Value;
                    }
                }
            }
        }

    }
}
