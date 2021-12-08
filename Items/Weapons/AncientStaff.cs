using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace AncientSandsMod.Items.Weapons
{
	public class AncientStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Staff"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Fires a orb of ancient energy");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 7;
			item.magic = true;
			item.width = 36;
			item.height = 36;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 7;
			item.value = 29361;
			item.rare = ItemRarityID.Lime;
			item.UseSound = SoundID.Item9;
			item.autoReuse = false;
			item.scale = 1;
			item.shoot = ModContent.ProjectileType<Projectiles.AncientEnergy>();
			item.shootSpeed = 10f;
			item.mana = 6;

		}

		public override void AddRecipes()
		{
			
		}
	}
}