using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;


namespace AncientSandsMod.Items.Materials
{
	public class MoonDust : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Moonshade Dust"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");

	
			//ItemID.Sets.ItemNoGravity[item.type] = true;

		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 24;
			item.maxStack = 999;
			item.value = 100;
			item.rare = ItemRarityID.White;

		}

		public override void AddRecipes()
		{

		}
	}
}