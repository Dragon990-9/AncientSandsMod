using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.Items.Weapons
{
	public class AncientKnife : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Knife"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("old knife");
		}

		public override void SetDefaults()
		{
			item.damage = 5;
			item.thrown = true;
			item.width = 10;
			item.height = 24;
			item.useTime = 30;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 20345;
			item.rare = ItemRarityID.Lime;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.scale = 1;
			item.shoot = ModContent.ProjectileType<Projectiles.AncientKnife>();
			item.shootSpeed = 5f;

		}

		
	}
}