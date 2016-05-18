using System;
using Xamarin.Forms;

namespace ListViewSample
{
	public class MyListViewCell : ViewCell
	{
		public MyListViewCell ()
		{
			var image = new Image () {
				VerticalOptions = LayoutOptions.Center,
			};
			image.SetBinding (Image.SourceProperty, "ProfileImage");

			var name = new Label () {
				VerticalOptions = LayoutOptions.Center,
			};
			name.SetBinding (Label.TextProperty, "Name");

			var addr = new Label () {
				VerticalOptions = LayoutOptions.Center,
			};
			addr.SetBinding (Label.TextProperty, "Address");

			var imageStack = new StackLayout () {
				VerticalOptions = LayoutOptions.Center,
				Children = {image}
			};

			var textStack = new StackLayout () {
				VerticalOptions = LayoutOptions.Center,
				Children = {name, addr}
			};

			var mainStack = new StackLayout () {
				VerticalOptions = LayoutOptions.Center,
				Orientation = StackOrientation.Horizontal,
				Spacing = 10,
				Children = {imageStack, textStack},
			};

			View = mainStack;
		}
	}
}

