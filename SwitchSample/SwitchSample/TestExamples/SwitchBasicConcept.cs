using System;
using Xamarin.Forms;

// Source: https://developer.xamarin.com/api/type/Xamarin.Forms.Switch/

namespace SwitchSample
{
	public class SwitchBasicConcept : ContentPage
	{
		Label label;

		public SwitchBasicConcept ()
		{
			var header = new Label () {
				Text = "Switch",
				HorizontalOptions = LayoutOptions.Center
			};

			var switcher = new Switch () {
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			switcher.Toggled += switcher_Toggled;

			label = new Label () {
				Text = "Switch is now False",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			// Accomodate iPhone status bar.
			this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

			// Build the page.
			this.Content = new StackLayout
			{
				Children =
				{
					header,	
					switcher,
					label
				}
			};

		}

		void switcher_Toggled(object sender, ToggledEventArgs e)
		{
			label.Text = String.Format("Switch is now {0}", e.Value);
		}
	}
}





