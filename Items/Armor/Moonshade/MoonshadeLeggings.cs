
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace AncientSandsMod.Items.Armor.Moonshade
{
	[AutoloadEquip(EquipType.Legs)]
	public class MoonshadeLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 30070;
			item.rare = ItemRarityID.White;
			item.defense = 4;
		}



		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Materials.MoonDust>(), 9);
			recipe.AddIngredient(ItemID.IronBar, 7);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}