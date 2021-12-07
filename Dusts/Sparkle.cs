using System.Drawing;
using Terraria;
using Terraria.ModLoader;

namespace AncientSandsMod.Dusts
{
	public class Sparkle : ModDust
	{
		public override void OnSpawn(Dust dust) {
			dust.velocity *= 0f;
			dust.noGravity = true;
			dust.noLight = true;
			dust.scale *= 1.5f;
		}

		public override bool Update(Dust dust) {
			dust.position += dust.velocity;
			dust.rotation += dust.velocity.X * 0.15f;
			dust.scale *= 0.99f;
			float light = 0.35f * dust.scale;
			Lighting.AddLight(dust.position, 0f, 0.2f, 0f);
			if (dust.scale < 0.5f) {
				dust.active = false;
			}
			return false;
		}

		public override Microsoft.Xna.Framework.Color? GetAlpha(Dust dust, Microsoft.Xna.Framework.Color lightColor)
		{
			return new Microsoft.Xna.Framework.Color(0, 255, 0, 25);
		}









	}
}