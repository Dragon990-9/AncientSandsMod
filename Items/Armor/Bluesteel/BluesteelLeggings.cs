
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace AncientSandsMod.Items.Armor.Bluesteel
{
	[AutoloadEquip(EquipType.Legs)]
	public class BluesteelLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("5% more walk speed");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 20000;
			item.rare = ItemRarityID.White;
			item.defense = 4;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.05f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Materials.BluesteelBar>(), 18);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}