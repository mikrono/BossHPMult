using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace BossHPMult.Config
{
    public class BossEntry
    {
        public BossEntry() : this( hp: 1f, damage: 1f, size: 1f) { }
        public BossEntry(float hp = 1f, float damage = 1f, float size = 1f)
        {
            HPScale = hp;
            DamageScale = damage;
            SizeScale = size;
        }
        [Range(0.1f, 1000f)]
        [Increment(0.1f)]
        [DrawTicks]
        [DefaultValue(1f)]
        public float HPScale;

        [Range(0.25f, 100f)]
        [Increment(0.25f)]
        [DrawTicks]
        [DefaultValue(1f)]
        public float DamageScale;

        [Range(0.1f, 10f)]
        [Increment(0.1f)]
        [DrawTicks]
        [DefaultValue(1f)]
        public float SizeScale;

        public override bool Equals(object obj)
        {
            if (obj is not BossEntry p)
            {
                return false;
            }

            return (HPScale == p.HPScale) && (DamageScale == p.DamageScale) && (SizeScale == p.SizeScale);
        }
    }
}
