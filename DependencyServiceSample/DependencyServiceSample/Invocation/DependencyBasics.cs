using System;

using Xamarin.Forms;

namespace DependencyServiceSample
{
	public class DependencyBasics : ContentPage
	{
		public DependencyBasics ()
		{
			// instantiate a new Button 
			var button = new Button () {
				Text = "Go Native",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};

			// adding events to the button
			button.Clicked += (sender, e) => 
			{
				// Invoking the platform-specific implementation of the ICustomClass interface

				// When clicked, DependencyService calls the platform-specific GoNative method of the
				// ICustomClass implementation, passing the text "platform-specific implementation complete!"
				// The registered/ implemented platform-specific version of CustomClass takes the text param,
				// adds the name of the OS at the beginning of the passed-in text string, and returns it
				// to the calling class in shared code which is basically in this example, it displays
				// the entire string in a DisplayAlert UI
				var text = DependencyService.Get<ICustomClass>().GoNative("platform-specific " +
					"implementation complete!");
				DisplayAlert("GoNative Called", text, "OK");
			};

			Content = button;
		}
	}
}


