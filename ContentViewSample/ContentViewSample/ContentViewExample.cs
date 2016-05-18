using System;

using Xamarin.Forms;

namespace ContentViewSample
{
	public class ContentViewExample : ContentPage
	{
		public ContentViewExample ()
		{
			// instantiate new ContentView
			ContentView contentView = new ContentView {
				// Customizing contentView Properties
				BackgroundColor = Color.Teal,
				Padding = new Thickness (40),
				HorizontalOptions = LayoutOptions.Fill,

				// created a label and assign it to content property of the contentView
				Content = new Label {
					Text = "a view, such as a label, a layout, or a layout of layouts", FontSize = 20,
					FontAttributes = FontAttributes.Bold,
					TextColor = Color.White
				}
			};

			// Padding on edges and a bit more for iPhone top status bar
			this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

			// add a stacklayout with the contentView assigned to the children property of the stacklayout 
			this.Content = new StackLayout
			{
				Children = {
					contentView
				}
			};
		}
	}
}


