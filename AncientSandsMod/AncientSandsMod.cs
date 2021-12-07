
using AncientSandsMod.UI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
//using AncientSandsMod.Items.AlchemistClass;
using Terraria;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace AncientSandsMod
{
	public class AncientSandsMod : Mod
	{

	/*	private UserInterface _potionsBarUserInterface;

		internal PotionsBar PotionsBar;
		internal UserInterface ExamplePersonUserInterface;
		private UserInterface _exampleUserInterface;
		internal GameUI ExampleUI;

		public override void Load()
		{
			PotionsBar = new PotionsBar();
			_potionsBarUserInterface = new UserInterface();
			_potionsBarUserInterface.SetState(PotionsBar);
		}

		public override void UpdateUI(GameTime gameTime)
		{

			if (GameUI.Visible)
			{
				_exampleUserInterface?.Update(gameTime);
			}
			_potionsBarUserInterface?.Update(gameTime);
			ExamplePersonUserInterface?.Update(gameTime);

		}

		public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
		{
			int resourceBarIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Resource Bars"));
			if (resourceBarIndex != -1)
			{
				layers.Insert(resourceBarIndex, new LegacyGameInterfaceLayer(
					"ExampleMod: Example Resource Bar",
					delegate {
						_potionsBarUserInterface.Draw(Main.spriteBatch, new GameTime());
						return true;
					},
					InterfaceScaleType.UI)
				);
			}
		}

	*/

	}
}