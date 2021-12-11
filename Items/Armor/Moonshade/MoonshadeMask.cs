
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace AncientSandsMod.Items.Armor.Moonshade
{
	[AutoloadEquip(EquipType.Head)]
	public class MoonshadeMask : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 30200;
			item.rare = ItemRarityID.White;
			item.defense = 5;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<MoonshadeChestplate>() && legs.type == ModContent.ItemType<MoonshadeLeggings>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "10% more magic damage";
		
			player.magicDamage += 0.1f;
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
			recipe.AddIngredient(ModContent.ItemType<Materials.MoonDust>(), 8);
			recipe.AddIngredient(ItemID.IronBar, 7);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}