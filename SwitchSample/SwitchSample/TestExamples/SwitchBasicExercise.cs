using System;

using Xamarin.Forms;

namespace SwitchSample
{
	public class SwitchBasicExercise : ContentPage
	{
		public SwitchBasicExercise ()
		{
			this.BackgroundColor = Color.Gray;

			var redLabel = new Label () {
				Text = "Gray",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			var blueLabel = new Label () {
				Text = "Yellow",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			var switcher = new Switch () {
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			switcher.Toggled += switcher_Toggled;

			var myStack = new StackLayout () {
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				Children = {redLabel, switcher, blueLabel}
			};

			Content = myStack;
		}

		void switcher_Toggled(object sender, ToggledEventArgs e)
		{
			bool switchValue = e.Value;

			if (switchValue == true) {
				this.BackgroundColor = Color.Yellow;
			} else {
				this.BackgroundColor = Color.Gray;
			}
		}
	}
}


