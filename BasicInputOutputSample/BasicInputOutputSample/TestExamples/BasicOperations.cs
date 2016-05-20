using System;

using Xamarin.Forms;

namespace BasicInputOutputSample
{
	public class BasicOperations : ContentPage
	{
		public BasicOperations ()
		{
			Label output = new Label();
			double firstNum = 0.0;
			double secondNum = 0.0;

			var firstEntry = new Entry () { Placeholder = "First Number" };
			firstEntry.TextChanged += (sender, e) => 
			{
			 firstNum = Convert.ToDouble(e.NewTextValue);
			};

			var secondEntry = new Entry () { Placeholder = "Second Number" };
			secondEntry.TextChanged += (sender, e) => 
			{
				secondNum = Convert.ToDouble(e.NewTextValue);
			};


			// Buttons
			var sumButton = new Button () { Text = "SUM" };
			sumButton.Clicked += (sender, e) => {
				double sum = firstNum + secondNum;
				output.Text = "Sum is " + sum.ToString();
			};

			var diffButton = new Button () { Text = "DIFFERENCE" };
			diffButton.Clicked += (sender, e) => {
				double diff = firstNum - secondNum;
				output.Text = "Difference is " + diff.ToString();
			};

			var proButton = new Button () { Text = "PRODUCT" };
			proButton.Clicked += (sender, e) => {
				double pro = firstNum * secondNum;
				output.Text = "Product is " + pro.ToString();
			};

			var qouButton = new Button () { Text = "QOUTIENT" };
			qouButton.Clicked += (sender, e) => {
				double qou = firstNum / secondNum;
				output.Text = "Qoutient is " + qou.ToString();
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


