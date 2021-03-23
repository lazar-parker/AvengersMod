using Terraria.ID;
using Terraria.ModLoader;

namespace avengersmod.Items
{
	public class Star : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Star");
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
			recipe.AddIngredient(ItemID.Silk, 4);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}