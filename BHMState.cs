using BossHPMult.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria;

namespace BossHPMult
{
    internal class BHMState
    {
        public static List<int> bossTypes;
        public static Dictionary<BossDefinition, BossEntry> SettingPairs;

        public static void Load()
        {
        }
        public static void Unload()
        {
            bossTypes = null;
            SettingPairs = null;
        }

        public static Dictionary<BossDefinition, BossEntry> InitValues()
        {
            if(bossTypes == null)
            {
                bossTypes = new List<int>();
            }
            NPC tempNPC = new();
            Dictionary<BossDefinition, BossEntry> pairs = new();


            List<string> NPCNameList = ((Dictionary<string, int>.KeyCollection)NPCID.Search.Names).ToList();
            NPCNameList.Remove("NegativeIDCount");
            foreach (string nPC in NPCNameList)
            {
                int nPCID = NPCID.Search.GetId(nPC);
                tempNPC.SetDefaults(nPCID);
                if (tempNPC.boss)
                {

                    bossTypes.Add(nPCID);
                }
            }


            //if (ModContent.GetInstance<BossHPMultConfig>().BossSettings != null)
            //{
            //    SettingPairs = SettingPairs.Concat(ModContent.GetInstance<BossHPMultConfig>()._bossSettings).ToDictionary(x => x.Key, x => x.Value);
            //}


            BossDefinition bossDefinition;
            BossEntry bossEntry;

            foreach (int nPCID in bossTypes)
            {
                bossDefinition = new BossDefinition(nPCID);
                bossEntry = new BossEntry();

                pairs.Add(bossDefinition, bossEntry);
            }

            return pairs;
        }
    }
}
