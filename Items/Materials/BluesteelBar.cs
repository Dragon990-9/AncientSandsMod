using Terraria.ID;
using Terraria.ModLoader;
using AncientSandsMod.Tiles;
using AncientSandsMod.Items.Placeable;

namespace AncientSandsMod.Items.Materials
{
	public class BluesteelBar : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Bluesteel Bar"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
		}

		public override void SetDefaults() 
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 5000;
			item.rare = ItemRarityID.Lime;
			
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Placeable.BluesteelOre>(), 4);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
		}
	}
}