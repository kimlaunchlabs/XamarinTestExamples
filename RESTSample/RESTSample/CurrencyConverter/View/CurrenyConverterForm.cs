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
				WidthRequest = 100
			};
			toEntry.SetBinding (Entry.TextProperty, "ToCurrency");

			var convertButton = new Button () {
				Text = "Convert"
			};
			convertButton.SetBinding (Button.CommandProperty, "Convert");

			// StackLayouts
			var fromStack = new StackLayout () {
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				Orientation = StackOrientation.Horizontal, 
				Children = {fromLabel, fromEntry} };

			var amountStack = new StackLayout () { 
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				Orientation = StackOrientation.Horizontal, 
				Children = {amountLabel, amountEntry} };

			var toStack = new StackLayout () { 
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				Orientation = StackOrientation.Horizontal, 
				Children = {toLabel, toEntry} };

			// main stack
			var mainStack = new StackLayout () { 
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Spacing =10,
				Children = {fromStack, toStack, amountStack, convertButton} 
			};

			Content = mainStack;
		}
	}
}


