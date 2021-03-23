using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace avengersmod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class Mark85Helmet : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Iron Man Mark 85 Helmet");
			Tooltip.SetDefault("The helmet worn by the late hero Iron Man");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 30;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("Mark85Breastplate") && legs.type == mod.ItemType("Mark85Greaves");
		}

        public override void UpdateArmorSet(Player player)
		{
			player.meleeDamage *= 2f;
			player.thrownDamage *= 1.5f;
			player.rangedDamage *= 2f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AdamantiteBar, 5); //changed from Copper to Adamantite, seemed more fitting. Also reduced overall cost
            recipe.AddIngredient(ItemID.GoldBar, 2);
            recipe.AddIngredient(ItemID.Glass, 2);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}