using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader.Config;
using Terraria.ModLoader;
using System.ComponentModel;

namespace BossHPMult.Config
{
    [TypeConverter(typeof(ToFromStringConverter<NPCDefinition>))]
    public class BossDefinition : NPCDefinition
    {
        public BossDefinition(int type) : base(type) { }
    }
}
