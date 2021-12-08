using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.Items.Materials
{
	public class AncientMetalPlating : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Metal Plating"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Sheets of old rusted metal, yet the rust seems to make the metal stronger");

		}

		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 16;
			item.maxStack = 999;
			item.value = 5000;
			item.rare = ItemRarityID.Lime;

		}

		public override void AddRecipes()
		{

		}
	}
}