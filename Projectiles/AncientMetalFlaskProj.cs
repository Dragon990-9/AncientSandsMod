using System;
using AncientSandsMod.Dusts;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.Projectiles
{
    public class AncientMetalFlaskProj : ModProjectile
    {
        public override void SetDefaults()
        {
            
            projectile.width = 30;
            projectile.height = 30;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 600;
            projectile.alpha = 0;
            projectile.extraUpdates = 1;
            


        }

        public override void AI()
        {
            Lighting.AddLight(projectile.position, 0f, 0.5f, 0f);
           

            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            if (Main.rand.NextBool(3))
            {
                Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, ModContent.DustType<Sparkle>(), projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);

            }
        }

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            
            projectile.Kill();

            projectile.soundDelay--;
            if (projectile.soundDelay <= 0)
            {
                Main.PlaySound(SoundID.Dig, (int)projectile.Center.X, (int)projectile.Center.Y, 1);
                projectile.soundDelay = 45;
                
            }



            return false;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)                //HERE
        {
            target.AddBuff(BuffID.CursedInferno, 40);
  
        }





    }
}