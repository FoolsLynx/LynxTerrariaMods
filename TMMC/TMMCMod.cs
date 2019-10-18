using Terraria.ModLoader;

namespace TMMC
{
	public class TMMCMod : Mod
	{
        public static TMMCMod Instance;

        public TMMCMod()
		{

		}

        public override void Load()
        {
            Instance = this;
        }
    }
}