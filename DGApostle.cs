using Terraria.ModLoader;

namespace DGApostle
{
	class DGApostle : Mod
	{
		public DGApostle()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
