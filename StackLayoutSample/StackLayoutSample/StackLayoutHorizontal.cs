using System;

using Xamarin.Forms;

namespace StackLayoutSample
{
	public class StackLayoutHorizontal : ContentPage
	{
		public StackLayoutHorizontal ()
		{
			// Defining page title
			Title = "Sample Vertical StackLayout";


			// Page Label Views
			var StartLabel = new Label () {
				Text = "Start",
				HorizontalOptions = LayoutOptions.Start,
			};

			var MiddleLabel = new Label () {
				Text = "Center",

				// 'Expand' layouts options are use to expand the views to fill the available area with space
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};

			var EndLabel = new Label () {
				Text = "End",
				HorizontalOptions = LayoutOptions.End
			};


			var stackLayout = new StackLayout () {

				// Sets the orientation of the StackLayout to Horizontal
				Orientation = StackOrientation.Horizontal,

				Padding = new Thickness (5,5,5,5),
				Spacing = 10,
				Children = {StartLabel, MiddleLabel, EndLabel}
			};

		
			Content = stackLayout;

		}
	}
}


