using Terraria.ID;
using Terraria.ModLoader;
using AncientSandsMod.Tiles;
using AncientSandsMod.Items.Placeable;

namespace AncientSandsMod.Items.Materials
{
	public class Pinecone : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pinecone"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 1000;
			item.rare = ItemRarityID.White;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BorealWood, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}

		
	}
}