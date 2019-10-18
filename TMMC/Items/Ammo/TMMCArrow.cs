using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TMMC.Items.Ammo
{
    public class TMMCArrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("TMMC: Arrow");
        }

        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.width = 10;
            item.height = 10;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1.2f;
            item.value = Item.buyPrice(copper: 50);
            item.rare = 2;
            item.shoot = mod.ProjectileType("TMMCArrowProj");
            item.shootSpeed = 8.5f;
            item.ammo = AmmoID.Arrow;
        }
    }
}
