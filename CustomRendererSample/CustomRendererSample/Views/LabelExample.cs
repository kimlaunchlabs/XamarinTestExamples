using System;

using Xamarin.Forms;

namespace CustomRendererSample
{
	public class LabelExample : ContentPage
	{
		public LabelExample ()
		{
			this.Title = "label Renderer Sample";

			var iLabel = new StyledLabel {
				Text = "I want to be italicized!",
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				styleType = StyleType.Italic,
			};
			var bLabel = new StyledLabel {
				Text = "I want to be bold! ",
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				styleType = StyleType.Bold
			};

			var bothLabel = new StyledLabel {
				Text = "I want to be italicized and bold!",
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				styleType = StyleType.BoldItalic
			};

			var stack  = new StackLayout {
				Padding = new Thickness(10,0,10,0),
				Spacing = 100,
				Children = { iLabel, bLabel, bothLabel }
			};

			Content = new ScrollView { 
				Content = stack
			};
		}
	}
}


