using System;

using Xamarin.Forms;
using TK.CustomMap.Api.Google;
using TK.CustomMap.Api;

namespace RESTSample
{
	public class App : Application
	{
		public static CurrencyItemManager currManager { get; private set;}

		public static GetWeatherItemManager weatherManager { get; private set;}

//		public static Page GetMainPage ()
//		{
//			// Currency Converter
//			//currManager = new CurrencyItemManager (new RestService ());
//			//var mainNav = new CurrenyConverterForm ();
//
//			// Weather Forcast
//			weatherManager = new GetWeatherItemManager (new RestService());
//			var mainNav = new WeatherInformationForm ();
//
//
//
//			return mainNav;
//		}
//
//		public static Page GetPage ()
//		{
//			var mainPage = GetMainPage ();
//			return mainPage;
//
//		}
		// com.google.android.maps.v2.API_KEY

		public App ()
		{
			//Currency Converter
//			currManager = new CurrencyItemManager (new RestService ());
//			MainPage = new CurrenyConverterForm ();

			// Weather Thing
			//weatherManager = new GetWeatherItemManager (new RestService());
			//MainPage = new WeatherInformationForm ();

			//GmsPlace.Init("YOUR API KEY");
			//GmsDirection.Init("AIzaSyCJN3Cd-Sp1a5V5OnkvTR-Gqhx7A3S-b6M");

			var mainPage = new NavigationPage(new TestPage());
			if (Device.OS == TargetPlatform.iOS)
			{
				mainPage.BarBackgroundColor = Color.FromHex("#f1f1f1");
			}
			MainPage = mainPage;

		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
			TKNativePlacesApi.Instance.DisconnectAndRelease();
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

