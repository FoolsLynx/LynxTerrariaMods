using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TMMC.Items.Pets
{
    public class TMMCPet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("TMMC: Pet");
            Tooltip.SetDefault("Summons a TMMC: Pet to follow the player.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.DD2PetGato);
            item.shoot = mod.ProjectileType("TMMCPet");
            item.buffType = mod.BuffType("TMMCPetBuff");
        }

        public override void UseStyle(Player player)
        {
            if(player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
    }
}
