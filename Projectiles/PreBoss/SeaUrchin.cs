using System;
using AncientSandsMod.Dusts;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientSandsMod.Projectiles.PreBoss
{
    public class SeaUrchin : ModProjectile
    {
        public override void SetDefaults()
        {

            projectile.width = 16;
            projectile.height = 16;
            projectile.aiStyle = 2;
            projectile.friendly = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 500;
            projectile.alpha = 0;
            projectile.extraUpdates = 1;



        }



            
        }

      



    }
