using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.NPCs.Bosses
{

	[AutoloadBossHead]
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class KingBat : ModNPC
	{



		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("King Cave Bat");
			Main.npcFrameCount[npc.type] = 3; // make sure to set this for your modnpcs.
		}

		public override void SetDefaults()
		{
			npc.width = 110;
			npc.height = 50;
			npc.boss = true;
			npc.height = 184;
			npc.damage = 20;
			npc.defense = 1;
			npc.lifeMax = 3500;
			npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath14;
			npc.value = 60f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 2;
			npc.scale = 1.4f;
			npc.behindTiles = false;
			npc.noTileCollide = true;
			

			//	aiType = NPCID.GiantMossHornet;





		}

		private const int Frame_1 = 0;
		private const int Frame_2 = 1;
		private const int Frame_3 = 2;
		private const int Frame_4 = 3;

		public override void FindFrame(int frameHeight)
		{
			//npc.frame.Y = (int)(npc.ai[0] / 40) * frameHeight;

			npc.frameCounter++;
			if (npc.frameCounter < 10)
			{
				npc.frame.Y = Frame_1 * frameHeight;
			}
			else if (npc.frameCounter < 20)
			{
				npc.frame.Y = Frame_2 * frameHeight;
			}
			else if (npc.frameCounter < 30)
			{
				npc.frame.Y = Frame_3 * frameHeight;
			}
			else
			{
				npc.frameCounter = 0;
			}

		}




		public override void HitEffect(int hitDirection, double damage)
		{
			for (int i = 0; i < 10; i++)
			{
				int dustType = Main.rand.Next(139, 143);
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, DustID.RedTorch);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
			}
		}


		public override void AI()
		{
			npc.spriteDirection = npc.direction;
			npc.ai[0]++; //or "npc.ai[0] += 1;", works the same way


			if (npc.ai[0] >= 180)
			{
				NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.CaveBat);

				npc.ai[0] = 0;
			}










		}







	}



}
