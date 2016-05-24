using System;

using Xamarin.Forms;

namespace CustomRendererSample
{
	public class App : Application
	{
		public static double ScreenHeight;
		public static double ScreenWidth;

		// Basic custom renderer concept
		public App ()
		{
			// Label Renderer
			//MainPage = new NavigationPage (new LabelExample());

			// Entry Renderer
			//MainPage = new NavigationPage (new EntryExample());


			// Map Renderer
			//MainPage = new NavigationPage (new MapPage());

			// Button Renderer
			//MainPage = new NavigationPage (new ButtonExample());

			// Page Renderer
			MainPage = new PageExample();

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


// * Reference: https://developer.xamarin.com/guides/xamarin-forms/custom-renderer/
