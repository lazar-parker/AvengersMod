using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace avengersmod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class Mark85Breastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Iron Man Mark 85 Chestplate");
			Tooltip.SetDefault("The armor worn by the late hero Iron Man");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 60;
		}

		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AdamantiteBar, 20); //changed from Copper to Adamantite, seemed more fitting. Also reduced overall cost
            recipe.AddIngredient(ItemID.GoldBar, 10);
            recipe.AddIngredient(null, "ArcReactor");
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}