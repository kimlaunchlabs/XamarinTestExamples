using System;

using Xamarin.Forms;

namespace RESTSample
{
	public class CurrenyConverterForm : ContentPage
	{
		public CurrenyConverterForm ()
		{
			this.BindingContext = new CurrenyConvertFormViewModel ();

			var fromLabel = new Label () { Text = "From" };

			var fromEntry = new Entry () {
				WidthRequest = 100
			};
			fromEntry.SetBinding (Entry.TextProperty, "FromCurrency");

			var amountLabel = new Label () { Text = "Amount" };

			var amountEntry = new Entry () {
				WidthRequest = 100
			};
			amountEntry.SetBinding (Entry.TextProperty, "AmountCurrency");

			var toLabel = new Label () { Text = "To" };

			var toEntry = new Entry () {
				WidthRequest = 100,
			};
			toEntry.SetBinding (Entry.TextProperty, "ToCurrency");


			var convertButton = new Button () {
				Text = "Convert"
			};
			convertButton.SetBinding (Button.CommandProperty, "Convert");

			var valueLabel = new Label () {
				
			};
			valueLabel.SetBinding (Label.TextProperty, "Balor");

			// StackLayouts
			var firstColumn = new StackLayout () {
				Padding = new Thickness (0,8,0,0),
				Spacing = 13,
				HorizontalOptions = LayoutOptions.EndAndExpand,
				Children = {fromLabel, toLabel, amountLabel} };

			var secondColumn = new StackLayout () { 
				HorizontalOptions = LayoutOptions.StartAndExpand,
				Children = {fromEntry, toEntry, amountEntry} };

			var toStack = new StackLayout () { 
				Spacing = 10,
				Orientation = StackOrientation.Horizontal, 
				Children = {firstColumn, secondColumn} 
			};

			// main stack
			var mainStack = new StackLayout () { 
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Spacing =15,
				Children = {toStack, convertButton, valueLabel} 
			};

			Content = mainStack;
		}
	}
}


