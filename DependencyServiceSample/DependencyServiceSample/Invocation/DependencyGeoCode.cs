using System;

using Xamarin.Forms;

namespace DependencyServiceSample
{
	public class DependencyGeoCode : ContentPage
	{
		Label placeLabel; 

		public DependencyGeoCode ()
		{

			var button = new Button () {
				Text = "Get Place",
				HorizontalOptions = LayoutOptions.Center
			};

			button.Clicked += (sender, e) => 
			{
				HandleLocation();
			};

			placeLabel = new Label () {
				HorizontalOptions = LayoutOptions.Center
			};

			var myStack = new StackLayout () {
				Spacing = 50,
				Children = {button, placeLabel}
			};

			Content = myStack;

		}

		public async void HandleLocation()
		{
			// Mandaue, Philippines Decimal Coordinates
			var currentLat = 10.333333;
			var currentLon = 123.933334;
			var address = await DependencyService.Get<IReverseGeoCode> ().ReverseGeoCodeLatLonAsync (currentLat, currentLon);
			if (address == null)
				return;
			placeLabel.Text = String.Format("{0}, {1}", address.City, address.Province);
			
		}
	}
}


