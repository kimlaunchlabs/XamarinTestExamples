using System;

using Xamarin.Forms;

namespace GridLayoutSample
{
	public class GridLayoutExample : ContentPage
	{
		public GridLayoutExample ()
		{
			// defining a grid that have 4 rows and 3 columns
			Grid grid = new Grid () {
				VerticalOptions = LayoutOptions.FillAndExpand,
				RowDefinitions = 
				{
					// Auto height of the grid row
					new RowDefinition { Height = GridLength.Auto },

					// Setting an exact/absolute height of grid row
					new RowDefinition { Height = new GridLength(200, GridUnitType.Absolute) },

					// Setting the the grid row height that expands the height to the available space of the screen, this is similar to FillAndExpand layout option
					new RowDefinition { Height = new GridLength(1,GridUnitType.Star) },

					new RowDefinition { Height = GridLength.Auto }
				},
				ColumnDefinitions = 
				{
					new ColumnDefinition { Width = GridLength.Auto },
					new ColumnDefinition { Width = GridLength.Auto },
					new ColumnDefinition { Width = GridLength.Auto }
				}
			};

			// Grid.Children.Add (view, indexColumn, indexRow), basically index starts in zero
			// adding a view to 0 columnIndex & 0 rowIndex
			grid.Children.Add(new Label
				{
					Text = "I'm at 0,0",
					FontSize = 30
				}, 0, 0);

			// adding a view to 1 columnIndex & 1 rowIndex
			grid.Children.Add(new Label
				{
					Text = "Me? 1,1",
					FontSize = 30,
					FontAttributes = FontAttributes.Bold,
					TextColor = Color.Black,
					BackgroundColor = Color.Lime
				}, 1, 1);

			// adding a view to 2 columnIndex & 2 rowIndex
			grid.Children.Add(new Label
				{
					Text = "2,2 here",
					FontSize = 25,
					FontAttributes = FontAttributes.Bold,
					TextColor = Color.White,
					BackgroundColor = Color.Red
				}, 2, 2);

			// adding a view to 0 columnIndex & 3 rowIndex
			grid.Children.Add(new Label
				{
					Text = "I'm at 0,3",
					FontSize = 30,
					FontAttributes = FontAttributes.Bold
				}, 0, 3);

			// adding a view to 3 columnIndex & 3 rowIndex
			grid.Children.Add(new Label
				{
					Text = "I'm at 3,3",
					FontSize = 30,
					FontAttributes = FontAttributes.Bold
				}, 3, 3);


			// Setting the content of the page to grid
			Content = grid;
		}
	}
}


