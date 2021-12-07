using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.NPCs
{

	[AutoloadBossHead]
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class KronosEye : ModNPC
	{



		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kronos's Eye");
			Main.npcFrameCount[npc.type] = 4; // make sure to set this for your modnpcs.
		}

		public override void SetDefaults()
		{
			npc.width = 184;
			npc.boss = true;
			npc.height = 184;
			npc.damage = 10;
			npc.defense = 5;
			npc.lifeMax = 75;
			npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath14;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 2;
			
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
			else if (npc.frameCounter < 40)
			{
				npc.frame.Y = Frame_4 * frameHeight;
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

			npc.ai[0]++; //or "npc.ai[0] += 1;", works the same way

			if (npc.ai[0] >= 50)
			{
				float Speed = 10f;
				Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
				int damage = 30;
				int type = ModContent.ProjectileType<Projectiles.BossProjectiles.KronosFlare>();
				Main.PlaySound(2, (int)npc.position.X, (int)npc.position.Y, 12);
				float rotation = (float)Math.Atan2(vector8.Y - (Main.player[npc.target].position.Y + (Main.player[npc.target].height * 0.5f)), vector8.X - (Main.player[npc.target].position.X + (Main.player[npc.target].width * 0.5f)));
				int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
				npc.ai[0] = 0;
			}

			





		}







	}



}
