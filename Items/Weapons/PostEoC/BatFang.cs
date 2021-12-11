using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.Items.Weapons.PostEoC
{
	public class BatFang : ModItem
	{
		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Ancient Knife"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 10;
			item.thrown = true;
			item.width = 10;
			item.height = 24;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 45;
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.scale = 1;
			item.shoot = ModContent.ProjectileType<Projectiles.PostEoC.BatFang>();
			item.shootSpeed = 5f;
			item.consumable = true;
			item.maxStack = 99;

		}


	}
}