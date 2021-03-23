using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace avengersmod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class Mark85Greaves : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Iron Man Mark 85 Greaves");
			Tooltip.SetDefault("The greaves worn by the late hero Iron Man");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 45;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.05f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperBar, 10); //changed from Copper to Adamantite, seemed more fitting. Also reduced overall cost
            recipe.AddIngredient(ItemID.GoldBar, 5);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}