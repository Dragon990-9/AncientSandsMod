
using AncientSandsMod.Dusts;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.Projectiles.BossProjectiles
{
	public class KronosFlare : ModProjectile
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kronos Flare");
		}
		public override void SetDefaults()
		{
			projectile.width = 16;
			projectile.height = 16;
			projectile.hostile = true;
			projectile.melee = true;
			projectile.penetrate = 1;
			projectile.timeLeft = 600;
			projectile.scale = 1.5f;
		}

		public override void AI()
		{

			projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X);
			Lighting.AddLight(projectile.position, 0f, 0.5f, 0f);

			projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X);
			projectile.alpha = 0;


			if (Main.rand.NextBool(1))
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, DustID.RubyBolt, projectile.velocity.X * 0f, projectile.velocity.Y * 0f);
				
			}
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{

			projectile.Kill();


			return false;
		}




		public override void Kill(int timeLeft)
		{
			for (int k = 0; k < 5; k++)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, ModContent.DustType<Sparkle>(), projectile.oldVelocity.X * 0.5f, projectile.oldVelocity.Y * 0.5f);
			}
			Main.PlaySound(0, projectile.position);
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			projectile.ai[0] += 0.1f;
			projectile.velocity *= 0.75f;
		}
	}



}
