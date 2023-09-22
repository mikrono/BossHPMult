using BossHPMult.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace BossHPMult
{
	public class BossHPMult : Mod
	{

        public override void Load()
        {
            BHMState.Load();
        }

        public override void Unload()
        {
            BHMState.Unload();
        }
    }
}