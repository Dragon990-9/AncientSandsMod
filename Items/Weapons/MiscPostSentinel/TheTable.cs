using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.Items.Weapons.MiscPostSentinel
{
	public class TheTable : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Table"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Oh no! Our table! It's broken!");
		}

		public override void SetDefaults()
		{
			item.damage = 16;
			item.thrown = true;
			item.noMelee = true;
			item.width = 27;
			item.height = 27;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 20345;
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.scale = 1;
			item.shoot = ModContent.ProjectileType<Projectiles.MiscPostSentinel.TheTable>();
			item.shootSpeed = 9f;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Materials.BluesteelBar>(), 5);
			recipe.AddIngredient(ItemID.GlassTable, 1);
			recipe.AddIngredient(ItemID.RedBrick, 17);


			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool CanUseItem(Player player)       //this make that you can shoot only 1 boomerang at once
		{
			for (int i = 0; i < 1000; ++i)
			{
				if (Main.projectile[i].active && Main.projectile[i].owner == Main.myPlayer && Main.projectile[i].type == item.shoot)
				{
					return false;
				}
			}
			return true;
		}
	}
}