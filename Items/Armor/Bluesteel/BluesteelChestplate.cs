
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.Items.Armor.Bluesteel
{
	[AutoloadEquip(EquipType.Body)]
	public class BluesteelChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Bluesteel Chestplate");
			
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 20000;
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
			recipe.AddIngredient(ModContent.ItemType<Materials.BluesteelBar>(), 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}