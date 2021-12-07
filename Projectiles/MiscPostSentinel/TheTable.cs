using System;
using AncientSandsMod.Dusts;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.Projectiles.MiscPostSentinel
{
    public class TheTable : ModProjectile
    {
        public override void SetDefaults()
        {

            projectile.width = 30;
            projectile.height = 30;
            projectile.aiStyle = 3;
            projectile.friendly = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 600;
            projectile.alpha = 0;
            projectile.extraUpdates = 1;
            



        }

        public override void AI()
        {
            Lighting.AddLight(projectile.position, 0.5f, 0.5f, 0.5f);


           
    
        }

        

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            projectile.Kill();

            projectile.soundDelay--;
            if (projectile.soundDelay <= 0)
            {
                Main.PlaySound(SoundID.Shatter, (int)projectile.Center.X, (int)projectile.Center.Y, 1);
                projectile.soundDelay = 45;

            }



            
        }







    }
}