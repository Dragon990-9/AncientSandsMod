using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.Items.Weapons.MoonshadeSet
{
	public class MoonshadeSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Moonshade Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 15;
			item.melee = true;
			item.width = 48;
			item.height = 56;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10270;
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.scale = 1;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Materials.MoonDust>(), 10);
			recipe.AddIngredient(ItemID.IronBar, 8);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();


		}
	}
}