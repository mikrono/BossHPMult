using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace BossHPMult
{
    internal class BossHPMultConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [DefaultValue(1)]
        [Range(1, 1000)]
        public int BHMValue;
    }
}
