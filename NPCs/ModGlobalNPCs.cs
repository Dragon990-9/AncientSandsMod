using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;



namespace AncientSandsMod.NPCs
{
    public class ChronosGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {

           //DEFENSE DRONE
            if (npc.type == ModContent.NPCType<NPCs.AncientDefenseDrone>())
            {
              //  if (Main.rand.Next(3) == 1)   //item rarity add {} if ur gonna use it
              
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AncientMetalPlating"), Main.rand.Next(2, 4));
              
            }


            //SENTINEL PROTOTYPE BOSS
            if (npc.type == ModContent.NPCType<NPCs.SentinelPrototypeHead>())
            {
                //  if (Main.rand.Next(3) == 1)   //item rarity add {} if ur gonna use it

                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AncientEnergy"), Main.rand.Next(15, 20));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AncientMetalPlating"), Main.rand.Next(15, 20));

            }
            //MOON MOTH
            if (npc.type == ModContent.NPCType<NPCs.Animals.MoonMoth>())
            {
                //  if (Main.rand.Next(3) == 1)   //item rarity add {} if ur gonna use it

                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MoonDust"), Main.rand.Next(3, 7));
                

            }
        }

    }
}