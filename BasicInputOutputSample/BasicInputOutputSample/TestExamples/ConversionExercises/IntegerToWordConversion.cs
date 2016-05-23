using System;

using Xamarin.Forms;

//C# Conversion Source Code: http://stackoverflow.com/questions/3213/convert-integers-to-written-numbers

namespace BasicInputOutputSample
{
	public class IntegerToWordConversion : ContentPage
	{
		Entry intEntry;
		Label inWords;

		public IntegerToWordConversion ()
		{
			intEntry = new Entry () {
				Placeholder = "Input positive whole number",
				Keyboard = Keyboard.Numeric,
				HorizontalOptions = LayoutOptions.Center
			};

			var convertButton = new Button () {
				Text = "Convert to Words",
				HorizontalOptions = LayoutOptions.Center
			};
			convertButton.Clicked += onButtonClicked;

			inWords = new Label () {
				HorizontalOptions = LayoutOptions.Center			
			};

			var mainStack = new StackLayout () {
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				Children = {intEntry, convertButton, inWords}
			};

			Content = mainStack;

		}

		void onButtonClicked (object sender, EventArgs e)
		{
			var inputtedNum = Convert.ToDouble(intEntry.Text);
			if (inputtedNum < 0) {
				DisplayAlert ("Error", "Invalid Input", "Close");
			} else {
				var output = NumberConversion.AmountInWords (inputtedNum);
				inWords.Text = output;
			}
		}


	}
}


