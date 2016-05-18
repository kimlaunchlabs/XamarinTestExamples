using System;

using Xamarin.Forms;

namespace CustomRendererSample
{
	public class EntryExample : ContentPage
	{
		public EntryExample ()
		{
			this.Title = "Entry Renderer Sample";

			var entrySample = new StyledEntry () {
				WidthRequest = 100,
				Placeholder = "TextCell Here",
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			Content = entrySample;
		}
	}
}


