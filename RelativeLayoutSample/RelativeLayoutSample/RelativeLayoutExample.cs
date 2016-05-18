using System;

using Xamarin.Forms;

namespace RelativeLayoutSample
{
	public class RelativeLayoutExample : ContentPage
	{
		public RelativeLayoutExample ()
		{
			Title = "RelativeLayout Example";

			RelativeLayout relativeLayout = new RelativeLayout ();

			var upperLeftLabel = new Label () {
				Text = "Upper Left",
				FontSize = 20
			};

			// Placing the upperLeftLabel view at coordinates 0,0 within the layout
			relativeLayout.Children.Add (upperLeftLabel, 
				Constraint.Constant (0),
				Constraint.Constant (0));

			var constantLabel = new Label () {
				Text = "Constants are Absolute",
				FontSize = 20
			};

			// Placing the constantLabel view at coordinates (100,100) with dimensions of 50 units wide and 200 units high
			relativeLayout.Children.Add (constantLabel,
				Constraint.Constant(100),
				Constraint.Constant(100),
				Constraint.Constant(50),
				Constraint.Constant(200));


			var halfwayDownLabel = new Label () {
				Text = "Halfway down and across",
				FontSize = 15
			};

			// Placing the halfwayDownLabel view to the half of the length and width of the parent layout, in this case it is relative to the ContentPage
			relativeLayout.Children.Add (halfwayDownLabel,
				Constraint.RelativeToParent ((parent) => 
					{
						// define the x value half of its parents view
						return parent.Width / 2;
					}),
				Constraint.RelativeToParent ((parent) => 
					{
						// define the y value half of its parents view
						return parent.Height / 2;
					})
			);

			var boxView = new BoxView () {
				Color = Color.Accent,
				WidthRequest = 150,
				HeightRequest = 150,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			// Placing the boxView view halfway down the height of the parent view with a height and width half of the parent view (x,y,view width, view height)
			relativeLayout.Children.Add (boxView,
				// define the x value to zero
				Constraint.Constant (0),

				// define the y value half of its parents view
				Constraint.RelativeToParent ((parent) => 
					{
						return parent.Height / 2;
					}),

				// define the width of the view to half of its parent view
				Constraint.RelativeToParent ((parent) =>
					{
						return parent.Width / 2;
					}),

				//define the height of the view to half of its parent view
				Constraint.RelativeToParent ((parent) =>
					{
						return parent.Height / 2;
					})
			);

			var belowLeftLabel = new Label () {
				Text = "Below Upper Left",
				FontSize = 15
			};

			// Place the belowLeftLabel view relative to upperLeftLabel view
			relativeLayout.Children.Add (belowLeftLabel,
				// define the x value of the view to zero
				Constraint.Constant(0),

				// define the y value of the view
				// This returns the sum of the sibling y value and height, in this case the sibling is the upperLeftLabel view
				Constraint.RelativeToView(upperLeftLabel, (parent, sibling) =>
					{
						return sibling.Y + sibling.Height;
					})
			);


			Content = relativeLayout;

		}
	}
}


