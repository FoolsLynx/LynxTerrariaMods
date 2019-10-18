using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace TMMC.Dusts
{
    public class TMMCGenericDust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.noGravity = true;
            dust.noLight = true;
            dust.scale = 2f;

        }

        public override bool Update(Dust dust)
        {
            dust.position += dust.velocity;
            dust.rotation += dust.velocity.X;
            dust.scale -= 0.1f;
            if (dust.scale < 0.5f)
            {
                dust.active = false;
            }

            return false;
        }
    }
}
