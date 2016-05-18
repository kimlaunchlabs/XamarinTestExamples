using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using CustomRendererSample;
using CustomRendererSample.Droid;
using Android.Graphics.Drawables;
using Android.Text;

[assembly: ExportRenderer (typeof(StyledEntry), typeof(StyledEntryRenderer))]
namespace CustomRendererSample.Droid
{
	public class StyledEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged (e);

			if (Control != null) {
				Control.SetBackgroundColor (global::Android.Graphics.Color.Orange);
			}
		}
	}
}

