using BossHPMult.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace BossHPMult
{
    public class BossHPMultGlobalProjectile : GlobalProjectile
    {
        public override void OnSpawn (Projectile projectile, IEntitySource source)
        {
            if (source is EntitySource_Parent)
            {
                if (((EntitySource_Parent)source).Entity is NPC nPC && BHMState.bossTypes.Contains(nPC.type))
                {
                    projectile.originalDamage *= ModContent.GetInstance<BossHPMultConfig>().BDamageMultiplierValue;
                }
            }
        }
    }
}
