
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace AncientSandsMod.Items.Armor.Bluesteel
{
	[AutoloadEquip(EquipType.Head)]
	public class BluesteelHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 20000;
			item.rare = ItemRarityID.White;
			item.defense = 7;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<BluesteelChestplate>() && legs.type == ModContent.ItemType<BluesteelLeggings>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "7% more damage";
			player.allDamage += 0.07f;
			/* Here are the individual weapon class bonuses.
			player.meleeDamage -= 0.2f;
			player.thrownDamage -= 0.2f;
			player.rangedDamage -= 0.2f;
			player.magicDamage -= 0.2f;
			player.minionDamage -= 0.2f;
			*/
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Materials.BluesteelBar>(), 18);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
