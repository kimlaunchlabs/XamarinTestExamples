using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using CustomRendererSample;
using CustomRendererSample.iOS;
using UIKit;

[assembly: ExportRenderer(typeof(StyledButton), typeof(StyledButtonRenderer))]
namespace CustomRendererSample.iOS
{
	public class StyledButtonRenderer : ButtonRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged (e);

			if (Control != null) {
				Control.BackgroundColor = UIColor.FromRGB(220, 180, 255);
			}
		}
	}
}

