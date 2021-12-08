using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.Items.Weapons.GraniteSet
{
	public class GraniteKnife : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Granite Knife"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 15;
			item.thrown = true;
			item.width = 10;
			item.height = 24;
			item.useTime = 30;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 10345;
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.scale = 1;
			item.shoot = ModContent.ProjectileType<Projectiles.GraniteKnife>();
			item.shootSpeed = 5f;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Diamond, 2);
			recipe.AddIngredient(ItemID.Granite, 20);

			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}


	}
}