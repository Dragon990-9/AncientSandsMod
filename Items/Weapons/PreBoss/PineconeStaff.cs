using Terraria.ID;
using Terraria.ModLoader;
using Terraria;


namespace AncientSandsMod.Items.Weapons.PreBoss
{
	public class PineconeStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pinecone Staff"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Shoots a pinecone");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 5;
			item.magic = true;
			item.width = 44;
			item.height = 44;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 2;
			item.value = 13361;
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item8;
			item.autoReuse = false;
			item.scale = 1;
			item.shoot = ModContent.ProjectileType<Projectiles.MiscPostSentinel.Pinecone>();
			item.shootSpeed = 6f;
			item.mana = 4;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Materials.Pinecone>(), 10);
			recipe.AddIngredient(ItemID.BorealWood, 15);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}