using System;
using AncientSandsMod.Dusts;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.Projectiles.MiscPostSentinel
{
    public class Pinecone : ModProjectile
    {
        public override void SetDefaults()
        {

            projectile.width = 28;
            projectile.height = 32;
            projectile.friendly = true;
            projectile.aiStyle = 1;
            projectile.penetrate = 1;
            projectile.timeLeft = 600;
            projectile.alpha = 0;
            projectile.extraUpdates = 1;
            projectile.scale = 0.5f;




        }

        public override void AI()
        {
            if (projectile.timeLeft < 550)
            {
                projectile.aiStyle = 2;

            }
          


        }



        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
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