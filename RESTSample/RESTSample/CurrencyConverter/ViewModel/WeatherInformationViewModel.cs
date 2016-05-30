using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Runtime.CompilerServices;

namespace RESTSample
{
	public class WeatherInformationViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public WeatherInformationViewModel ()
		{
			
		}

		private string location;
		public string Location
		{
			get {
				return location;
			}
			set {
				location = value;
				OnPropertyChanged ();
			}
		}
			

		//City
		private string city;
		public string City
		{
			get {
				return city;
			}
			set {
				city = value;
				OnPropertyChanged ();
			}
		}

		//Country
		private string country;
		public string Country
		{
			get {
				return country;
			}
			set {
				country = value;
				OnPropertyChanged ();
			}
		}

		//Longitude
		private double longitude;
		public double Longitude
		{
			get {
				return longitude;
			}
			set {
				longitude = value;
				OnPropertyChanged ();
			}
		}

		//Latitude
		private double latitude;
		public double Latitude
		{
			get {
				return latitude;
			}
			set {
				latitude = value;
				OnPropertyChanged ();
			}
		}

		//WeatherMain
		private string weatherMain;
		public string WeatherMain
		{
			get {
				return weatherMain;
			}
			set {
				weatherMain = value;
				OnPropertyChanged ();
			}
		}

		//WeatherDesc
		private string weatherDesc;
		public string WeatherDesc
		{
			get {
				return weatherDesc;
			}
			set {
				weatherDesc = value;
				OnPropertyChanged ();
			}
		}

		private double temperature;
		public double Temperature
		{
			get {
				return temperature;
			} 
			set {
				temperature = value;
				OnPropertyChanged ();
			}
		}

		public ICommand GetWeather
		{
			get {
				return new Command (async () => {
					try { 
						var a = await App.weatherManager.GetWeatherAsync(Location);

						string thisWeatherMain = "";
						string thisWeatherDesc = "";


						foreach (var c in a.weather)
						{
							thisWeatherMain += c.main;
							thisWeatherDesc += c.description;
						}

						City = a.name;
						Country = a.sys.country;
						Longitude = a.coord.lon;
						Latitude = a.coord.lat;
						WeatherMain = thisWeatherMain;
						WeatherDesc = thisWeatherDesc;
						Temperature = a.main.temp;


						//System.Diagnostics.Debug.WriteLine("Final " + thisWeather);

					} catch (Exception ex) {
						System.Diagnostics.Debug.WriteLine("here "+ex.Message);
					}
				});
			}
		}

		public void OnPropertyChanged ([CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) {
				handler (this, new PropertyChangedEventArgs (propertyName));
			}
		}
	}
}

