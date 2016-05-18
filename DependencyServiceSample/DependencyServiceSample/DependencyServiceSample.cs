using System;

using Xamarin.Forms;

namespace DependencyServiceSample
{
	public class App : Application
	{
		public App ()
		{
			// -- Dependency Basic Concept
			MainPage = new DependencyBasics();

			// -- DependencyService Convert Decimal Coordinates to string
			//MainPage = new DependencyGeoCode();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

