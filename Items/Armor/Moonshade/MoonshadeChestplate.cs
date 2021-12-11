
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.Items.Armor.Moonshade
{
	[AutoloadEquip(EquipType.Body)]
	public class MoonshadeChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Moonshade Chestplate");

		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 30400;
			item.rare = ItemRarityID.White;
			item.defense = 5;
		}

		/*public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
			player.statManaMax2 += 20;
			player.maxMinions++;
		}*/

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Materials.MoonDust>(), 15);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}