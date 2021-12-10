using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.Items.Weapons.PreBoss
{
	public class SeaUrchin : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sea Urchin"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 5;
			item.thrown = true;
			item.width = 10;
			item.height = 24;
			item.useTime = 20;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 295;
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.scale = 1;
			item.shoot = ModContent.ProjectileType<Projectiles.PreBoss.SeaUrchin>();
			item.shootSpeed = 4f;
		
			

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Starfish, 5);
			recipe.AddIngredient(ItemID.Coral, 8);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
