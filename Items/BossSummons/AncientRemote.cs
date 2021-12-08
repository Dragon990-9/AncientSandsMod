using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using AncientSandsMod;

namespace AncientSandsMod.Items.BossSummons
{
	public class AncientRemote : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Remote"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Summons the guardian of an ancient city" +
				"\nMust be used in the desert");
			ItemID.Sets.SortingPriorityBossSpawns[item.type] = 13; // This helps sort inventory know this is a boss summoning item.
		}

		public override void SetDefaults()
		{


			item.width = 20;
			item.height = 20;
			item.maxStack = 20;
			item.rare = ItemRarityID.Cyan;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = ItemUseStyleID.HoldingUp;
			item.UseSound = SoundID.Item44;
			item.consumable = true;

			item.scale = 1;

		}

		public override bool CanUseItem(Player player)
		{
			// "player.ZoneUnderworldHeight" could also be written as "player.position.Y / 16f > Main.maxTilesY - 200"
			return player.ZoneDesert && !NPC.AnyNPCs(ModContent.NPCType<NPCs.SentinelPrototypeHead>());
		}

		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<NPCs.SentinelPrototypeHead>());
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Materials.AncientMetalPlating>(), 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}