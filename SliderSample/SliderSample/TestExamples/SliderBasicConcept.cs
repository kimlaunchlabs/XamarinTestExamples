using System;

using Xamarin.Forms;

//Source: https://developer.xamarin.com/api/constructor/Xamarin.Forms.Slider.Slider()/

namespace SliderSample
{
	public class SliderBasicConcept : ContentPage
	{
		Label label;

		public SliderBasicConcept ()
		{
			var header = new Label () {
				Text = "Slider",
				HorizontalOptions = LayoutOptions.Center
			};

			var slider = new Slider
			{
				Minimum = 0,
				Maximum = 100,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			slider.ValueChanged += OnSliderValueChanged;

			label = new Label
			{
				Text = "Slider value is 0",
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
					slider,
					label
				}
			};
		}

		void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
		{
			label.Text = String.Format("Slider value is {0:F1}", e.NewValue);
		}
	}
}


