using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.NPCs
{
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class AncientDefenseDrone : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Defense Drone");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.DemonEye]; // make sure to set this for your modnpcs.
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 32;
			npc.damage = 10;
			npc.defense = 5;
			npc.lifeMax = 75;
			npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath14;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 14;
		//	aiType = NPCID.GiantMossHornet;
			animationType = NPCID.DemonEye;
		
	
	
		}



		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return spawnInfo.player.ZoneDesert ? 0.2f : 0f;

		}

		public override void HitEffect(int hitDirection, double damage)
		{
			for (int i = 0; i < 10; i++)
			{
				int dustType = Main.rand.Next(139, 143);
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, ModContent.DustType<Dusts.Sparkle>());
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
			}
		}


		public override void AI()
		{

			npc.ai[0]++; //or "npc.ai[0] += 1;", works the same way

	if (npc.ai[0] >= 90)
	{
	float Speed = 20f;
	Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
	int damage = 30;
				int type = ModContent.ProjectileType<Projectiles.EnemyGreenLaser>();
	Main.PlaySound(2, (int) npc.position.X, (int) npc.position.Y, 12);
	float rotation = (float) Math.Atan2(vector8.Y-(Main.player[npc.target].position.Y+(Main.player[npc.target].height * 0.5f)), vector8.X-(Main.player[npc.target].position.X+(Main.player[npc.target].width * 0.5f)));
	int num54 = Projectile.NewProjectile(vector8.X, vector8.Y,(float)((Math.Cos(rotation) * Speed)*-1),(float)((Math.Sin(rotation) * Speed)*-1), type, damage, 0f, 0);
	npc.ai[0] = 0;
	}

			
		}

		





	}



}
