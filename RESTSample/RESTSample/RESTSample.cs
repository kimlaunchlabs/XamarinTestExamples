using System;

using Xamarin.Forms;

namespace RESTSample
{
	public class App : Application
	{
		public static CurrencyItemManager currManager { get; private set;}

		public static Page GetMainPage ()
		{
			currManager = new CurrencyItemManager (new RestService ());

			var mainNav = new CurrenyConverterForm ();

			return mainNav;
		}

		public static Page GetPage ()
		{
			var mainPage = GetMainPage ();
			return mainPage;

		}




//		public App ()
//		{
//			// The root page of your application
//			MainPage = new CurrenyConverterForm ();
//		}
//
//		protected override void OnStart ()
//		{
//			// Handle when your app starts
//		}
//
//		protected override void OnSleep ()
//		{
//			// Handle when your app sleeps
//		}
//
//		protected override void OnResume ()
//		{
//			// Handle when your app resumes
//		}
	}
}

