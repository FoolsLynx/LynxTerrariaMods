using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace TMMC.Items.Placeables.Walls
{
    public class TMMCGenericWall : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("TMMC: Generic Wall");
        }

        public override void SetDefaults()
        {
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;
            item.consumable = true;
            item.useStyle = 1;
            item.useTime = 12;
            item.useAnimation = 12;
            item.createWall = mod.WallType("TMMCGenericWall");
            item.autoReuse = true;
            item.useTurn = true;
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod, "TMMCGenericTile", 4);
            r.AddTile(TileID.WorkBenches);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
