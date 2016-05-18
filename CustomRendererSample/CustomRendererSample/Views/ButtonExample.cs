using System;

using Xamarin.Forms;

namespace CustomRendererSample
{
	public class ButtonExample : ContentPage
	{
		public ButtonExample ()
		{
			this.Title = "Button Renderer Example";

			var button = new StyledButton () {
				Text = "Test Button",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center
			};

			Content = button;

		}
	}
}


