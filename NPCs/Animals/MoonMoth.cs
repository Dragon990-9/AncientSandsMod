using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.NPCs.Animals
{
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class MoonMoth : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Moonshade Moth");
			Main.npcFrameCount[npc.type] = 4; // make sure to set this for your modnpcs.
		}

		public override void SetDefaults()
		{
			npc.damage = 5;
			npc.width = 22;
			npc.height = 24;
			npc.defense = 5;
			npc.lifeMax = 30;
			npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath14;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
		
			npc.aiStyle = 2;



		}



		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return !Main.dayTime && NPC.downedBoss1 ? 0.2f : 0;

		}

		


		public override void AI()
		{

			//npc.rotation = (float)Math.Atan2((double)npc.velocity.Y, (double)npc.velocity.X) + 1.5f;
			npc.spriteDirection = npc.direction;

			if (Main.rand.NextBool(3))
			{
				int dustType = Main.rand.Next(139, 143);
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, DustID.BlueTorch);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
			}
		}

		private const int Frame_1 = 0;
		private const int Frame_2 = 1;
		private const int Frame_3 = 2;
		private const int Frame_4 = 3;

		public override void FindFrame(int frameHeight)
		{
			//npc.frame.Y = (int)(npc.ai[0] / 40) * frameHeight;

			npc.frameCounter++;
			if (npc.frameCounter < 5)
			{
				npc.frame.Y = Frame_1 * frameHeight;
			}
			else if (npc.frameCounter < 10)
			{
				npc.frame.Y = Frame_2 * frameHeight;
			}
			else if (npc.frameCounter < 15)
			{
				npc.frame.Y = Frame_3 * frameHeight;
			}
			else if (npc.frameCounter < 20)
			{
				npc.frame.Y = Frame_4 * frameHeight;
			}
			else
			{
				npc.frameCounter = 0;
			}

		}







	}



}
