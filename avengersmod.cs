using Terraria.ModLoader;

namespace avengersmod
{
	class avengersmod : Mod
	{
		public avengersmod()
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
