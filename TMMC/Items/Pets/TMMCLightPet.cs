using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TMMC.Items.Pets
{
    public class TMMCLightPet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("TMMC: Light Pet");
            Tooltip.SetDefault("Summons a TMMC: Light Pet to follow the player.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.DD2PetGato);
            item.shoot = mod.ProjectileType("TMMCLightPet");
            item.buffType = mod.BuffType("TMMCLightPetBuff");
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
    }
}
