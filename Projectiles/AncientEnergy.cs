
using AncientSandsMod.Dusts;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.Projectiles
{
	public class AncientEnergy : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.penetrate = 1;
			projectile.timeLeft = 600;
		}

		public override void AI()
		{
			Lighting.AddLight(projectile.position, 0f, 0.5f, 0f);

			projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.5f;
			projectile.alpha = 0;


			if (Main.rand.NextBool(3))
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, ModContent.DustType<Sparkle>(), projectile.velocity.X * 0f, projectile.velocity.Y * 0f);

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
			Main.PlaySound(SoundID.Item25, projectile.position);
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			projectile.ai[0] += 0.1f;
			projectile.velocity *= 0.75f;
		}
	}



}
