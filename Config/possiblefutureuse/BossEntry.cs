using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader.IO;

namespace BossHPMult.Config
{
    internal class BossEntry : TagSerializable
    {

        public string Name { get; set; } = String.Empty;
        public string ModName { get; set; } = String.Empty;
        public int Type { get; set; } = -100;
        public int HMValue { get; set; } = 1;

        public BossEntry(string name, string modName, int type, int multiplier)
        {
            Name = name;
            ModName = modName;
            Type = type;
            HMValue = multiplier;
        }

        public TagCompound SerializeData()
        {
            return new TagCompound
            {
                { "name", Name },
                { "modName", ModName },
                { "type", Type },
                { "multiplier", HMValue },
            };
        }
    }
}
