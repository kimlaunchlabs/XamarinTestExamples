using System;
using Xamarin.Forms;
using CustomRendererSample;
using CustomRendererSample.Droid;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(StyledButton), typeof(StyledButtonRenderer))]
namespace CustomRendererSample.Droid
{
	public class StyledButtonRenderer : ButtonRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged (e);

			if (Control != null) {
				Control.SetBackgroundColor (global::Android.Graphics.Color.Rgb(220, 180, 255));
			}
		}
	}
}

