using System;
using BossHPMult.Config;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace BossHPMult
{
    public class BossHPMultGlobalNPC : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (BHMState.bossTypes.Contains(npc.type))
            {
                var config = ModContent.GetInstance<BossHPMultConfig>();

                int BHMValue = config.BHealthMultiplierValue;
                int HPLimit = (int)Math.Floor(int.MaxValue / (float)BHMValue);
                npc.lifeMax = (npc.lifeMax < HPLimit) ? npc.lifeMax * BHMValue : int.MaxValue;

                int BDMValue = config.BDamageMultiplierValue;
                npc.damage *= BDMValue;

                int BSMValule = config.BSizeMultiplierValue;
                npc.Size *= BSMValule;
            }
        }
    }
}
