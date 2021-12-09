using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.Items.Weapons.PreBoss
{
	public class WoodenDart : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wooden Dart"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 3;
			item.thrown = true;
			item.width = 10;
			item.height = 24;
			item.useTime = 21;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 345;
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.scale = 1;
			item.shoot = ModContent.ProjectileType<Projectiles.PreBoss.WoodenDart>();
			item.shootSpeed = 5f;
			item.maxStack = 999;
			item.consumable = true;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 3);
			recipe.anyWood = true;
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 5);
			recipe.AddRecipe();
		}
	}
}
