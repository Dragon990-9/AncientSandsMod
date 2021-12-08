using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;


namespace AncientSandsMod.Items.Materials
{
	public class AncientEnergy : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Ancient Energy"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");

			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 4));
			ItemID.Sets.AnimatesAsSoul[item.type] = true;
			ItemID.Sets.ItemIconPulse[item.type] = true;
			//ItemID.Sets.ItemNoGravity[item.type] = true;

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