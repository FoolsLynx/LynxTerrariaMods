using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace TMMC.Items
{
    public class TMMCGenericItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("TMMC: Generic Item");
            Tooltip.SetDefault("This is the generic tooltip, you can use\n\"\\n\" to create a new line!");
        }

        public override void SetDefaults()
        { 
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
        }
    }
}
