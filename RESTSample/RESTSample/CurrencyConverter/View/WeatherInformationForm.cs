using System;

using Xamarin.Forms;

namespace RESTSample
{
	public class WeatherInformationForm : ContentPage
	{
		public WeatherInformationForm ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


