using System;
using Xamarin.Forms;
using CustomRendererSample;
using CustomRendererSample.Droid;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;

[assembly: ExportRenderer(typeof(StyledLabel), typeof(StyledLabelRenderer))]
namespace CustomRendererSample.Droid
{
	public class StyledLabelRenderer : LabelRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged (e);

			var styledLabel = (StyledLabel)Element;

			switch (styledLabel.styleType) {
			case StyleType.Bold:
				Control.SetTypeface (null, TypefaceStyle.Bold);
				break;
			case StyleType.Italic:
				Control.SetTypeface (null, TypefaceStyle.Italic);
				break;
			case StyleType.BoldItalic:
				Control.SetTypeface (null, TypefaceStyle.BoldItalic);
				break;
			}
		}
	}
}

