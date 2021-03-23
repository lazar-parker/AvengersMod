using Terraria.ID;
using Terraria.ModLoader;

namespace avengersmod.Items
{
	public class RedSilk : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Red Silk");
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
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddIngredient(ItemID.RedDye, 1);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(this, 1);
			recipe2.AddTile(TileID.WaterDrip);
			recipe2.SetResult(ItemID.Silk);
			recipe2.AddRecipe();
		}
	}
}