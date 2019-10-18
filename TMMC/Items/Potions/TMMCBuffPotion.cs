using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TMMC.Items.Potions
{
    public class TMMCBuffPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("TMMC: Buff Potion");
            Tooltip.SetDefault("Potion with give TMMC: Generic Buff");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useTurn = true;
            item.maxStack = 30;
            item.consumable = true;
            item.UseSound = SoundID.Item3;
        }

        public override bool CanUseItem(Player player)
        {
            return !player.HasBuff(mod.BuffType("TMMCGenericBuff"));
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(mod.BuffType("TMMCGenericBuff"), 600);
            return base.UseItem(player);
        }
    }
}
