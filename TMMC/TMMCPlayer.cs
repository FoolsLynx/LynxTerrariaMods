using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace TMMC
{
    public class TMMCPlayer : ModPlayer
    {
        public bool tmmcPet;

        public bool tmmcBiome;

        public override void ResetEffects()
        {
            tmmcPet = false;
        }

        public override void UpdateBiomes()
        {
            tmmcBiome = TMMCWorld.tmmcGenericTile > 100;
        }

        public override bool CustomBiomesMatch(Player other)
        {
            TMMCPlayer modOther = other.GetModPlayer<TMMCPlayer>();
            return tmmcBiome == modOther.tmmcBiome;
        }

        public override void CopyCustomBiomesTo(Player other)
        {
            TMMCPlayer modOther = other.GetModPlayer<TMMCPlayer>();
            modOther.tmmcBiome = tmmcBiome;
        }

        public override void SendCustomBiomes(BinaryWriter writer)
        {
            BitsByte flags = new BitsByte();
            flags[0] = tmmcBiome;
            writer.Write(flags);
        }

        public override void ReceiveCustomBiomes(BinaryReader reader)
        {
            BitsByte flags = reader.ReadByte();
            tmmcBiome = flags[0];
        }

    }
}
