using Terraria;
using Terraria.ModLoader;

namespace TMMC.Buffs.Buffs
{
    public class TMMCGenericBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("TMMC: Generic Buff");
            Description.SetDefault("This Buff will give the Player / NPC a few effects.");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            // This will increase the regen rate of health.
            player.lifeRegen += 4;
            // This increases the movement speed of the player.
            player.moveSpeed += 0.75f;
            // This will give the player the "Water Breathing" effect
            player.gills = true;
            // Increase our defence by a value of 6.
            player.statDefense += 6;

            // Some other options include:
            player.maxMinions += 2;
            player.minionDamage += 1.25f;

            player.meleeCrit += 10;
            player.meleeDamage += 1.25f;

            player.rangedCrit += 10;
            player.rangedDamage += 1.25f;

            player.thrownCrit += 10;
            player.thrownDamage += 1.25f;

            player.magicCrit += 10;
            player.magicDamage += 1.25f;

            player.statLifeMax2 += 50; // Use statLifeMax2 for increasing max health
        }
    }
}
