using Terraria.ID;
using Terraria.ModLoader;

namespace avengersmod.Items
{
	public class EmptyGauntlet : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Empty Gauntlet");
			Tooltip.SetDefault("This could be something useful,"
                 + "\nif only you could find something for the holes.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 1;
			item.value = 1;
			item.rare = 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 10);
            recipe.AddIngredient(ItemID.LunarBar, 4);
            recipe.AddIngredient(ItemID.LifeCrystal, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}