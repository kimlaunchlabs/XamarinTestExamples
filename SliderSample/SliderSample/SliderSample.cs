using System;

using Xamarin.Forms;

namespace SliderSample
{
	public class App : Application
	{
		public App ()
		{
			// Slider Example
			MainPage = new SliderBasicConcept();

			// Slider Exercises
			//MainPage = new SliderBasicExercise ();
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

