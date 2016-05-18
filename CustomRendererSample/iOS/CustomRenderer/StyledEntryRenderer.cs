using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using CustomRendererSample;
using CustomRendererSample.iOS;
using UIKit;


[assembly: ExportRenderer(typeof(StyledEntry), typeof(StyledEntryRenderer))]
namespace CustomRendererSample.iOS
{
	public class StyledEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged (e);

			if (Control != null) {
				Control.BackgroundColor = UIColor.Orange;
			}
		}
	}
}

