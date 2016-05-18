using System;

using Xamarin.Forms;

namespace StackLayoutSample
{
	public class App : Application
	{
		public App ()
		{
			// -- Vertical StackLayout Sample
			MainPage = new NavigationPage (new StackLayoutVertical());

			// -- Horizontal StackLayout Sample
			//MainPage = new NavigationPage (new StackLayoutHorizontal());
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

