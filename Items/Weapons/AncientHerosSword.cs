using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.Items.Weapons
{
	public class AncientHerosSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Ancient Hero's Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A mysterious blade, forged from a powerful metal");
		}

		public override void SetDefaults() 
		{
			item.damage = 10;
			item.melee = true;
			item.width = 26;
			item.height = 26;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Lime;
			item.UseSound = SoundID.Item1;
			
			item.scale = 1;
			
		}

		public override void AddRecipes() 
		{
			
		}
	}
}