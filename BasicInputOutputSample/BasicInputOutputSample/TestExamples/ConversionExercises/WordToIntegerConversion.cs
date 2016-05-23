using System;

using Xamarin.Forms;


//C# Conversion Source Code: http://stackoverflow.com/questions/11278081/convert-words-string-to-int

namespace BasicInputOutputSample
{
	public class WordToIntegerConversion : ContentPage
	{

		Entry intEntry;
		Label inWords;

		public WordToIntegerConversion ()
		{
			intEntry = new Entry () {
				Placeholder = "string",
				//Keyboard = Keyboard.Numeric,
			};

			var convertButton = new Button () {
				Text = "Convert to Integer"
			};
			convertButton.Clicked += onButtonClicked;

			inWords = new Label () {
				HorizontalOptions = LayoutOptions.Center			
			};

			var mainStack = new StackLayout () {
				//HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.Center,
				Children = {intEntry, convertButton, inWords}
			};

			Content = mainStack;
		}

		void onButtonClicked (object sender, EventArgs e)
		{
			var output = NumberConversion.ParseEnglish(intEntry.Text);
			inWords.Text = output.ToString ();
		}
	}
}


