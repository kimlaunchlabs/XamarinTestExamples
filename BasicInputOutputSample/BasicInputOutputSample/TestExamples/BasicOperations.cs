using System;

using Xamarin.Forms;

namespace BasicInputOutputSample
{
	public class BasicOperations : ContentPage
	{
		Label output; 

		public BasicOperations ()
		{
			var firstEntry = new Entry () { Placeholder = "First Number" };

			var secondEntry = new Entry () { Placeholder = "Second Number" };


			// Buttons
			var sumButton = new Button () {
				Text = "SUM"
			};
			sumButton.Clicked += (sender, e) => {
				
			};

			var diffButton = new Button () {
				Text = "DIFFERENCE"
			};
			diffButton.Clicked += (sender, e) => {
				
			};

			var proButton = new Button () {
				Text = "PRODUCT"
			};
			proButton.Clicked += (sender, e) => {

			};

			var qouButton = new Button () {
				Text = "QOUTIENT"
			};
			qouButton.Clicked += (sender, e) => {

			};
			// End Buttons


			// Label for displaying the output
			output = new Label () {
				HorizontalOptions = LayoutOptions.Center,
				Text = "0",
				FontSize = 50
			};


			// StackLayouts
			var entryStack = new StackLayout () {
				Children = {firstEntry, secondEntry}
			};

			var buttonStack = new StackLayout () {
				Children = {sumButton, diffButton, proButton, qouButton}
			};

			var outputStack = new StackLayout () {
				Children = {output}
			};

			var mainStack = new StackLayout () {
				VerticalOptions = LayoutOptions.Center,
				Children = {entryStack, buttonStack, outputStack}
			};

			Content = mainStack;
		}
			
	}
}


