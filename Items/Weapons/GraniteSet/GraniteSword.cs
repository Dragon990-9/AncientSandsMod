using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.Items.Weapons.GraniteSet
{
	public class GraniteSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Granite Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 20;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10020;
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item1;

			item.scale = 1.3f;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Diamond, 3);
			recipe.AddIngredient(ItemID.Granite, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}