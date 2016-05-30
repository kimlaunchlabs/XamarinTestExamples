using System;

using Xamarin.Forms;

namespace RESTSample
{
	public class WeatherInformationForm : ContentPage
	{
		public WeatherInformationForm ()
		{
			this.BindingContext = new WeatherInformationViewModel ();

			var locationLabel = new Label () {

			};

			var locationEntry = new Entry () {
				Placeholder = "Enter City / Location"
			};
			locationEntry.SetBinding (Entry.TextProperty, "Location");

			var myButton = new Button () {
				Text = "Get Weather"
			};
			myButton.SetBinding (Button.CommandProperty, "GetWeather");

			//---------

			var cityLabel = new Label () {
				Text = "Location"
			};

			var cityText = new Label () {

			};
			cityText.SetBinding (Label.TextProperty, "City");

			var countryLabel = new Label () {
				Text = "Country"
			};

			var countryText = new Label () {

			};
			countryText.SetBinding (Label.TextProperty, "Country");

			var longLabel = new Label () {
				Text = "Longitude"
			};

			var longText = new Label () {

			};
			longText.SetBinding (Label.TextProperty, "Longitude");

			var latLabel = new Label () {
				Text = "Latitude"
			};

			var latText = new Label () {

			};
			latText.SetBinding (Label.TextProperty, "Latitude");

			var weatherMainLabel = new Label () {
				Text = "Weather"
			};

			var weatherMainText = new Label () {

			};
			weatherMainText.SetBinding (Label.TextProperty, "WeatherMain");

			var weatherDescLabel = new Label () {
				Text = "Weather Description"
			};

			var weatherDescText = new Label () {

			};
			weatherDescText.SetBinding (Label.TextProperty, "WeatherDesc");

			var tempLabel = new Label () {
				Text = "Temperature"
			};

			var tempText = new Label () {

			};
			tempText.SetBinding (Label.TextProperty, "Temperature");

			var labelFirstStack = new StackLayout () {
				Children = {cityLabel, countryLabel, longLabel, latLabel, weatherMainLabel, weatherDescLabel, tempLabel}
			};
			var labelSecondStack = new StackLayout () {
				Children = {cityText, countryText, longText, latText, weatherMainText, weatherDescText, tempText}
			};
				
			var buttonStack = new StackLayout () {
				Children = {myButton}
			};

			var responseStack = new StackLayout () {
				Orientation = StackOrientation.Horizontal,
				Children =  {labelFirstStack, labelSecondStack}
			};

			var mainStack = new StackLayout () {
				Padding = new Thickness (0,Device.OnPlatform(20,0,0),0,0),
				Children = {locationLabel, locationEntry, buttonStack, responseStack}
			};

			Content = mainStack;
		}
	}
}


