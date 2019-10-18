using Terraria;
using Terraria.ModLoader;

namespace TMMC.Buffs.Debuffs
{
    public class TMMCGenericDebuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("TMMC: Generic Debuff");
            Description.SetDefault("This Buff will give the Player / NPC a few effects.");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen -= 2;
            player.meleeDamage -= 0.5f;
            player.rangedDamage -= 0.5f;
            player.thrownDamage -= 0.5f;
            player.magicDamage -= 0.5f;
            player.minionDamage -= 0.5f;
        }

    }
}
