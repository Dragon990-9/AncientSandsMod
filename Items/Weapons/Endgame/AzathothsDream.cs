using AncientSandsMod.Projectiles;
//using ExampleMod.Tiles;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.Items.Weapons.Endgame
{
	public class AzathothsDream : ModItem
	{
		// You can use a vanilla texture for your item by using the format: "Terraria/Item_<Item ID>".
		public static Color OverrideColor = new Color(255, 0, 0);


		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Azathoth's Dream");
			Tooltip.SetDefault("'What is reality, if not a dream'");
		}

		public override void SetDefaults()
		{
			// Start by using CloneDefaults to clone all the basic item properties from the vanilla Last Prism.
			// For example, this copies sprite size, use style, sell price, and the item being a magic weapon.
			item.CloneDefaults(ItemID.LastPrism);
			item.mana = 4;
			item.damage = 200;
			item.shoot = ModContent.ProjectileType<Projectiles.Endgame.AzathothsDreamHoldout>();
			item.shootSpeed = 30f;

			// Change the item's draw color so that it is visually distinct from the vanilla Last Prism.
			item.color = OverrideColor;
		}

		public override void AddRecipes()
		{
			
		}

		// Because this weapon fires a holdout projectile, it needs to block usage if its projectile already exists.
		public override bool CanUseItem(Player player) => player.ownedProjectileCounts[ModContent.ProjectileType<Projectiles.Endgame.AzathothsDreamHoldout>()] <= 0;
	}
}
