using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace TMMC
{
    public class TMMCWorld : ModWorld
    {
        public static int tmmcGenericTile;

        public override void TileCountsAvailable(int[] tileCounts)
        {
            tmmcGenericTile = tileCounts[mod.TileType("TMMCGenericTile")];
        }

        public override void ResetNearbyTileEffects()
        {
            tmmcGenericTile = 0;
        }
    }
}
