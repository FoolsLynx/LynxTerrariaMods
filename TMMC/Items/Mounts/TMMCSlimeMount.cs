using Terraria;
using Terraria.ID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace TMMC.Items.Mounts
{
    public class TMMCSlimeMount : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("TMMC: Slime Mount");
            Tooltip.SetDefault("Summons a rideable TMMC: Slime Mount.");
        }

        public override void SetDefaults()
        {
            item.width = 36;
            item.height = 34;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 6f;
            item.value = Item.buyPrice(silver: 15);
            item.UseSound = SoundID.Item81;
            item.noMelee = true;
            item.mountType = mod.MountType("TMMCSlimeMount");
        }
    }
}
