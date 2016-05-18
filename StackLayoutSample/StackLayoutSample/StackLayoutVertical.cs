using System;

using Xamarin.Forms;

namespace StackLayoutSample
{
	public class StackLayoutVertical : ContentPage
	{
		public StackLayoutVertical ()
		{
			// Defining page title
			Title = "Sample Vertical StackLayout";


			// Page Label Views
			var StartLabel = new Label () {
				Text = "Start is flush left",
				HorizontalOptions = LayoutOptions.Start,
			};

			var MiddleLabel = new Label () {
				Text = "Center",
				HorizontalOptions = LayoutOptions.Center
			};

			var EndLabel = new Label () {
				Text = "End is flush right",
				HorizontalOptions = LayoutOptions.End
			};


			var stackLayout = new StackLayout () {

				// Setting an inner padding in the StackLayout
				// Padding = new Thickness (Left, ,Top, Right, Bottom),
				Padding = new Thickness (5,5,5,5),

				// Setting a space between child elements in the StackLayout
				Spacing = 10,

				// assigns the Label Views to the Children property of the StackLayout
				Children = {StartLabel, MiddleLabel, EndLabel}
			};


			// Assigns the content of the page to the StackLayout
			Content = stackLayout;
				
		}
	}
}


