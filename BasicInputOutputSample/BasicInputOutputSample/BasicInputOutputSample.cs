using System;

using Xamarin.Forms;

namespace BasicInputOutputSample
{
	public class App : Application
	{
		public App ()
		{
			// basic operations
		//	MainPage = new BasicOperations ();

			// Int to string Conversion
			//MainPage = new IntegerToWordConversion ();

			// string to int conversion
			//MainPage = new WordToIntegerConversion ();

			// Exeption (Console)
			//MainPage = new ExceptionExample ();

			// IEnumerable Samples
			MainPage = new Example1();


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

