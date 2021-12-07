using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace AncientSandsMod.UI
{
	// ExampleUIs visibility is toggled by typing "/coin" in chat. (See CoinCommand.cs)
	// ExampleUI is a simple UI example showing how to use UIPanel, UIImageButton, and even a custom UIElement.
	internal class GameUI : UIState
	{
		
		
		public static bool Visible;

		// In OnInitialize, we place various UIElements onto our UIState (this class).
		// UIState classes have width and height equal to the full screen, because of this, usually we first define a UIElement that will act as the container for our UI.
		// We then place various other UIElement onto that container UIElement positioned relative to the container UIElement.
		public override void OnInitialize()
		{
			
		}

		private void PlayButtonClicked(UIMouseEvent evt, UIElement listeningElement)
		{
			Main.PlaySound(SoundID.MenuOpen);
			
		}

		private void CloseButtonClicked(UIMouseEvent evt, UIElement listeningElement)
		{
			Main.PlaySound(SoundID.MenuClose);
			Visible = false;
		}

		/*private void ExampleButtonClicked(UIMouseEvent evt, UIElement listeningElement)
		{
			var examplePlayer = Main.LocalPlayer.GetModPlayer<ExamplePlayer>();
			examplePlayer.nonStopParty = !examplePlayer.nonStopParty;
			ExampleButton.HoverText = "SendClientChanges Example: Non-Stop Party " + (examplePlayer.nonStopParty ? "On" : "Off");
		}*/

		
	}

	

		//DateTime dpsEnd;
		//DateTime dpsStart;
		//int dpsDamage;
		//public bool dpsStarted;
		//public DateTime dpsLastHit;

		// Array of ints 60 long.
		// "length" = seconds since reset
		// reset on button or 20 seconds of inactivity?
		// pointer to index so on new you can clear previous
		

		

		

		
	}

	

