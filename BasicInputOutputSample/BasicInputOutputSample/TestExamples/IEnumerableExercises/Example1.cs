using System;

using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;


// Source: http://www.c-sharpcorner.com/UploadFile/dacca2/implement-ienumerable-interface-in-C-Sharp/

namespace BasicInputOutputSample
{
	public class Example1 : ContentPage
	{
		Label myLabel = new Label();

		public Example1 ()
		{
			var myButton = new Button () { Text = "Click Me" };
			myButton.Clicked += (sender, e) => 
			{
				
			};

			myLabel = new Label () { Text = " dd" };

			var myStack = new StackLayout () {
				Children = {myButton, myLabel}
			};

			Content = myStack;
		}

		void OnMyButtonClicked (object sender, EventArgs e)
		{
			int b = 0;
			IEnumerable<int> Values = from value in Enumerable.Range(1, 10) select value;
			foreach (int a in Values) {
				System.Diagnostics.Debug.WriteLine (a);
				//myLabel.Text = a.ToString();
			}
		}
	}
}


