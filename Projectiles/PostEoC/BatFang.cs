using System;
using AncientSandsMod.Dusts;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.Projectiles.PostEoC
{
    public class BatFang : ModProjectile
    {
        public override void SetDefaults()
        {

            projectile.width = 10;
            projectile.height = 24;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 500;
            projectile.alpha = 0;
            projectile.extraUpdates = 1;
            projectile.scale = 1.2f;



        }

        public override void AI()
        {
           


            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
          
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
            projectile.Kill();


            projectile.soundDelay--;
            if (projectile.soundDelay <= 0)
            {
                Main.PlaySound(SoundID.Dig, (int)projectile.Center.X, (int)projectile.Center.Y, 1);
                projectile.soundDelay = 45;

            }

          


        }





    }
}