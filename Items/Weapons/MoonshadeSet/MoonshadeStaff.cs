using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace AncientSandsMod.Items.Weapons.MoonshadeSet
{
	public class MoonshadeStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Ancient Staff"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.AmethystStaff);
			item.damage = 17;
			item.magic = true;
			item.width = 42;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 2;
			item.value = 13823;
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item9;
			item.autoReuse = false;
			item.scale = 1;
			item.shootSpeed = 11f;
			item.mana = 7;
			item.noMelee = true;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Materials.MoonDust>(), 8);
			recipe.AddIngredient(ItemID.IronBar, 7);
			recipe.AddIngredient(ItemID.FallenStar, 4);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();


		}
	}
}