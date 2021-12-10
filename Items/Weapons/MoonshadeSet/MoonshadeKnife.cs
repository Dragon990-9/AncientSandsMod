using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.Items.Weapons.MoonshadeSet
{
	public class MoonshadeKnife : ModItem
	{
		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Ancient Knife"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 14;
			item.thrown = true;
			item.width = 10;
			item.height = 24;
			item.useTime = 25;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 10465;
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.noMelee = true;
			item.scale = 1;
			item.shoot = ModContent.ProjectileType<Projectiles.PostEoC.MoonshadeKnife>();
			item.shootSpeed = 6f;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Materials.MoonDust>(), 9);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddIngredient(ItemID.Wood, 8);
			recipe.anyWood = true;
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();


		}


	}
}