using System;

using Xamarin.Forms;

namespace FrameLayoutSample
{
	public class FrameLayoutExample : ContentPage
	{
		public FrameLayoutExample ()
		{
			var label = new Label () {
				Text = "Frame Example"
			};

			//instantiate new Frame
			var myFrame = new Frame () {
				// sets the frame outline color to red
				OutlineColor = Color.Red,

				// add the label view to the frame content property
				Content = label,

				// sets the frame horizontally and vertically center
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,

				// sets the height and width of the frame to 100
				HeightRequest = 100,
				WidthRequest = 100,
			};

			Content = myFrame;
		}
	}
}


