using System;

using Xamarin.Forms;

namespace AbsoluteLayoutSample
{
	public class AbsoluteLayoutExample : ContentPage
	{
		public AbsoluteLayoutExample ()
		{
			// instantiate new Absolute Layout
			AbsoluteLayout absoluteLayout = new AbsoluteLayout ();

			var firstLabel = new Label () {
				Text = "First Label"
			};

			// add the firstLabel view to the Children property of the layout
			absoluteLayout.Children.Add (firstLabel);

			// defining the LayoutFlags of the view
			AbsoluteLayout.SetLayoutFlags (firstLabel, AbsoluteLayoutFlags.PositionProportional);

			// defining the LayoutBounds of the view with a rectangle (x-value, y-value, width, height)
			// x and y values are ranging from 0 to 1, but if incase you will not define the LayoutFlags of the view or set it to 'None', rectangle x and y values can be range from zero to device screen's width and height
			AbsoluteLayout.SetLayoutBounds (firstLabel, new Rectangle (0,0, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

			//or
			//absoluteLayout.Children.Add (firstLabel, new Rectangle (0,0, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize), AbsoluteLayoutFlags.PositionProportional);

			//or
			//absoluteLayout.Children.Add (firstLabel, new Point(1,0));
			//bsoluteLayout.SetLayoutFlags (firstLabel, AbsoluteLayoutFlags.PositionProportional);

			var secondLabel = new Label {
				Text = "Second Label"
			};

			absoluteLayout.Children.Add (secondLabel);
			AbsoluteLayout.SetLayoutFlags (secondLabel, AbsoluteLayoutFlags.PositionProportional);
			AbsoluteLayout.SetLayoutBounds (secondLabel, new Rectangle (0,1, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));



			// Setting the content of page
			Content = absoluteLayout;
		}
	}
}


