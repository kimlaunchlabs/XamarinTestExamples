using System;

using Xamarin.Forms;

namespace MVVMTestSample
{
	public class MVVMTestView : ContentPage
	{
		public MVVMTestView ()
		{
			
			this.BindingContext = new MVVMTestViewModel();

			var nameLabel = new Label () {
				Text = "Name"
			};

			var nameEntry = new Entry () {

			};
			nameEntry.SetBinding (Entry.TextProperty, "Name");


			var datelabel = new Label () {
				Text = "Last Updated"
			};

			var dateBind = new Label () {

			};
			dateBind.SetBinding (Label.TextProperty, "Updated");

			var myButton = new Button () {
				Text = "Save my Name",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center
			};
			myButton.SetBinding (Button.CommandProperty, "Save");

			var myStack = new StackLayout () {
				HorizontalOptions = LayoutOptions.Center,
				Padding = new Thickness (0,30,0,0),
				Children = {nameLabel, nameEntry, datelabel, dateBind, myButton}
			};

			this.Content = myStack;
		}
	}
}


