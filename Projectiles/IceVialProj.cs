using System;
using AncientSandsMod.Dusts;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.Projectiles
{
    public class IceVialProj : ModProjectile
    {
        public override void SetDefaults()
        {

            projectile.width = 30;
            projectile.height = 30;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 240;
            projectile.alpha = 0;
            projectile.extraUpdates = 1;



        }

        public override void AI()
        {
            Lighting.AddLight(projectile.position, 0f, 0.2f, 0.5f);


            // projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            // if (Main.rand.NextBool(3))
            // {
            //      Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, ModContent.DustType<Sparkle>(), projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
            //
            //  }

            if (projectile.timeLeft <= 3)
            {
                projectile.position.X = projectile.position.X + (float)(projectile.width / 2);
                projectile.position.Y = projectile.position.Y + (float)(projectile.height / 2);
                projectile.width = 128;
                projectile.height = 128;
                projectile.alpha = 255;


                projectile.soundDelay--;
                if (projectile.soundDelay <= 0)
                {
                    Main.PlaySound(SoundID.Shatter, (int)projectile.Center.X, (int)projectile.Center.Y, 1);
                    projectile.soundDelay = 45;

                }


            }

        }


       




    public override bool OnTileCollide(Vector2 oldVelocity)
        {


            projectile.aiStyle = 2;
            

            return false;
        }

        public override void Kill(int timeLeft)
        {
            for (int k = 0; k < 5; k++)
                for (int i = 0; i < 16; i++)
                {
                    Dust.NewDustPerfect(projectile.Center + new Vector2(80, 0).RotatedBy(i * Math.PI * 2 / 16f), ModContent.DustType<Sparkle>());
                }
            Main.PlaySound(SoundID.Item25, projectile.position);
        }



        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)                //HERE
        {

            target.AddBuff(BuffID.Frostburn, 180);
        }





    }
}