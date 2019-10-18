using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TMMC.Items.Globals
{
    public class TMMCGlobalItem : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            ItemID.Sets.ExtractinatorMode[mod.ItemType("TMMCGenericTile")] = mod.ItemType("TMMCGenericTile");
        }

        public override void ExtractinatorUse(int extractType, ref int resultType, ref int resultStack)
        {
            if (extractType == mod.ItemType("TMMCGenericTile"))
            {
                int r = Main.rand.Next(10);
                if(r <= 3)
                {
                    resultType = mod.ItemType("TMMCGenericItem");
                    resultStack = 1;
                } else if(r > 3 && r <= 8)
                {
                    resultType = mod.ItemType("TMMCBuffPotion");
                    resultStack = 1;
                } else
                {
                    resultType = ItemID.CopperOre;
                    resultStack = 1;
                }
            }
        }
    }
}
