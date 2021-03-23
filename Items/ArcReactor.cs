using Terraria.ID;
using Terraria.ModLoader;

namespace avengersmod.Items
{
	public class ArcReactor : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Arc Reactor");
			Tooltip.SetDefault("A very useful item."
            + "\nIt's humming with powerful energy.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = 1;
			item.rare = 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AdamantiteBar, 10);
            recipe.AddIngredient(ItemID.LunarBar, 2);
            recipe.AddIngredient(ItemID.BlueDye, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}