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
    public class TMMCDebufPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("TMMC: Debuff Potion");
            Tooltip.SetDefault("Potion with give TMMC: Generic Debuff");
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
            return !player.HasBuff(mod.BuffType("TMMCGenericDebuff"));
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(mod.BuffType("TMMCGenericDebuff"), 600);
            return base.UseItem(player);
        }
    }
}
