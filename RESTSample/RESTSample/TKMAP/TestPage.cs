using System;

using Xamarin.Forms;

namespace RESTSample
{
	public class TestPage : ContentPage
	{
		public TestPage ()
		{
			var myButton = new Button ()
			{
				Text = "Pass Value",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};
			myButton.Clicked += (sender, e) => 
			{
				Navigation.PushAsync (new MapPage(9.3072200,123.3026100));
			};


			Content = myButton;
		}
	}
}


