using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace AncientSandsMod.Items.Weapons.GraniteSet
{
	public class GraniteStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Granite Staff"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.SapphireStaff);
			item.damage = 15;
			item.magic = true;
			item.width = 26;
			item.height = 26;
			item.useTime = 23;
			item.useAnimation = 23;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 5;
			item.value = 10023;
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item1;
			item.mana = 9;
			item.noMelee = true;
			item.shootSpeed = 9f;

			item.scale = 1;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Diamond, 3);
			recipe.AddIngredient(ItemID.Granite, 20);
			recipe.AddIngredient(ItemID.FallenStar, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}