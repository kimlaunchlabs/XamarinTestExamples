using System;

using Xamarin.Forms;

namespace SwitchSample
{
	public class App : Application
	{
		public App ()
		{
			// Switch Example
			//MainPage = new SwitchBasicConcept ();

			// Switch Exercise
			MainPage = new SwitchBasicExercise ();
	
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

