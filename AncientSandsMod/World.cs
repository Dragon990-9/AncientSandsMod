using AncientSandsMod.Items;
using AncientSandsMod.Tiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;

namespace AncientSandsMod
{
    class World : ModWorld
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        { 
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (ShiniesIndex != -1)
            {
                tasks.Insert(ShiniesIndex + 1, new PassLegacy("Mod Ores", ModOres));
            }

            int LivingTreesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Living Trees"));
            if (LivingTreesIndex != -1)
            {
                tasks.Insert(LivingTreesIndex + 1, new PassLegacy("Post Terrain", delegate (GenerationProgress progress) {
                    // We can inline the world generation code like this, but if exceptions happen within this code 
                    // the error messages are difficult to read, so making methods is better. This is called an anonymous method.
                    progress.Message = "Ancient Weapons";  
					MakeAncientChest();
                }));
            }
			

		}
		private void MakeAncientChest()
		{
			float widthScale = Main.maxTilesX / 4200f;
			int numberToGenerate = WorldGen.genRand.Next(1, (int)(2f * widthScale));
			for (int k = 0; k < numberToGenerate; k++)
			{
				bool success = false;
				int attempts = 0;
				while (!success)
				{
					attempts++;
					if (attempts > 1000)
					{
						success = true;
						continue;
					}
					int i = WorldGen.genRand.Next(300, Main.maxTilesX - 300);
					if (i <= Main.maxTilesX / 2 - 50 || i >= Main.maxTilesX / 2 + 50)
					{
						int j = 0;
						while (!Main.tile[i, j].active() && (double)j < Main.worldSurface)
						{
							j++;
						}
						if (Main.tile[i, j].type == TileID.Dirt)
						{
							j--;
							if (j > 150)
							{
								bool placementOK = true;
								for (int l = i - 4; l < i + 4; l++)
								{
									for (int m = j - 6; m < j + 20; m++)
									{
										if (Main.tile[l, m].active())
										{
											int type = (int)Main.tile[l, m].type;
											if (type == TileID.BlueDungeonBrick || type == TileID.GreenDungeonBrick || type == TileID.PinkDungeonBrick || type == TileID.Cloud || type == TileID.RainCloud)
											{
												placementOK = false;
											}
										}
									}
								}
								if (placementOK)
								{
									//success = PlaceWell(i, j);
									int chestIndex = WorldGen.PlaceChest(i, j, style: 15);
									if (chestIndex != -1)
									{
										
										Chest chest = Main.chest[chestIndex];
										// itemsToAdd will hold type and stack data for each item we want to add to the chest
										var itemsToAdd = new List<(int type, int stack)>();

										// Here is an example of using WeightedRandom to choose randomly with different weights for different items.


										//Tuple.Create(ModContent.ItemType<Items.Materials.BluesteelBar>(), 7.0);
										
										
										 //Using a switch statement and a random choice to add sets of items.
										switch (Main.rand.Next(1))
										{
										case 0:
												itemsToAdd.Add((ModContent.ItemType<Items.Weapons.AncientHerosSword>(), 1));
												itemsToAdd.Add((ModContent.ItemType<Items.Weapons.AncientRevolver>(), 1));
												itemsToAdd.Add((ModContent.ItemType<Items.Weapons.AncientStaff>(), 1));
												itemsToAdd.Add((ModContent.ItemType<Projectiles.Minions.AncientSpirit.AncientScepter>(), 1));
												itemsToAdd.Add((ModContent.ItemType<Items.Weapons.AncientKnife>(), 1));
												break;
											
										}

										// Finally, iterate through itemsToAdd and actually create the Item instances and add to the chest.item array
										int chestItemIndex = 0;
										foreach (var itemToAdd in itemsToAdd)
										{
											Item item = new Item();
											item.SetDefaults(itemToAdd.type);
											item.stack = itemToAdd.stack;
											chest.item[chestItemIndex] = item;
											chestItemIndex++;
											if (chestItemIndex >= 40)
												break; // Make sure not to exceed the capacity of the chest
										}

										break;
									}
								}
							}
						}
					}
				}
			}
		}

		


		private void ModOres(GenerationProgress progress)
        {
            progress.Message = "Generating Bluesteel";

            for (int k = 0; k < (int)((Main.maxTilesX * Main.maxTilesY) * 6E-05); k++)
            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY);

                WorldGen.TileRunner(x, y, WorldGen.genRand.Next(5, 13), WorldGen.genRand.Next(3, 6), ModContent.TileType<BluesteelOre>());

            }


        }

       /* public override void PostWorldGen()
        {
            // Place some items in Golden Chests
            int[] itemsToPlaceInGoldChests = { ModContent.ItemType<Items.Weapons.AncientHerosSword>(), ModContent.ItemType<Items.Weapons.AncientRevolver>(), ModContent.ItemType<Items.Weapons.AncientStaff>(), ModContent.ItemType<Items.AlchemistClass.AncientBand>(), ModContent.ItemType<Projectiles.Minions.AncientSpirit.AncientScepter>() };
            int itemsToPlaceInGoldChestsChoice = 0;
            for (int chestIndex = 0; chestIndex < 1000; chestIndex++)
            {
                Chest chest = Main.chest[chestIndex];
                // If you look at the sprite for Chests by extracting Tiles_21.xnb, you'll see that the 12th chest is the Ice Chest. Since we are counting from 0, this is where 11 comes from. 36 comes from the width of each tile including padding. 
                if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 1 * 36)
                {
                    for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++)
                    {
                        if (chest.item[inventoryIndex].type == ItemID.None)
                        {
                            chest.item[inventoryIndex].SetDefaults(itemsToPlaceInGoldChests[itemsToPlaceInGoldChestsChoice]);
                            itemsToPlaceInGoldChestsChoice = (itemsToPlaceInGoldChestsChoice + 1) % itemsToPlaceInGoldChests.Length;
                            // Alternate approach: Random instead of cyclical: chest.item[inventoryIndex].SetDefaults(Main.rand.Next(itemsToPlaceInIceChests));

                        }
                    }
                    

                }
            }
        }*/




    }
}
