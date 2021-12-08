using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.Items.Weapons
{
	public class HerosSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Hero's Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Fires a burst of ancient energy");
		}

		public override void SetDefaults() 
		{
			item.damage = 30;
			item.melee = true;
			item.width = 27;
			item.height = 27;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 20345;
			item.rare = ItemRarityID.Lime;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.scale = 1;
			item.shoot = ModContent.ProjectileType<Projectiles.HerosSword>();
			item.shootSpeed = 10f;
			
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Materials.BluesteelBar>(), 8);
			recipe.AddIngredient(ModContent.ItemType<Items.Materials.AncientEnergy>(), 15);
			recipe.AddIngredient(ModContent.ItemType<Items.Weapons.AncientHerosSword>(), 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}