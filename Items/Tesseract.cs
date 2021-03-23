using Terraria.ID;
using Terraria.ModLoader;

namespace avengersmod.Items
{
	public class Tesseract : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("OOOOOOhhhhhh...."
            + "\nShiny...");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 100;
			item.rare = 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 20);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}