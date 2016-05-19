using System;
using Xamarin.Forms;

namespace ListViewSample
{
	public class ListViewExample : ContentPage
	{
		public ListViewExample ()
		{
			this.BindingContext = new MyListViewModel ();
			this.Title = "ListView Example";

			var person = new PersonData ();

			var myList = new ListView () {
				ItemsSource = person.Persona,
				ItemTemplate = new DataTemplate (typeof(MyListViewCell)),
				HasUnevenRows = true,
			};
		

			var addButton = new Button () {
				
			};

			var myStack = new StackLayout () {
				Children = {myList}
			};

			// some codes here

			Content = myStack;

		}
	}
}

