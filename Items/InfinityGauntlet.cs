using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace avengersmod.Items
{
    public class InfinityGauntlet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Infinity Gauntlet");
            Tooltip.SetDefault("Like the one from Marvel," + "\nbut better!");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 28;
            item.value = 10000;
            item.rare = 4;
            item.accessory = true;
            item.defense = 100;
            item.lifeRegen = 100;
        }
       
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.meleeDamage += 19f;
			player.thrownDamage += 19f;
			player.rangedDamage += 19f;
			player.magicDamage += 19f;
			player.minionDamage += 19f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "PowerStone", 1);
            recipe.AddIngredient(null, "SpaceStone", 1);
            recipe.AddIngredient(null, "RealityStone", 1);
            recipe.AddIngredient(null, "SoulStone", 1);
            recipe.AddIngredient(null, "TimeStone", 1);
            recipe.AddIngredient(null, "MindStone", 1);
            recipe.AddIngredient(null, "EmptyGauntlet", 1);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}