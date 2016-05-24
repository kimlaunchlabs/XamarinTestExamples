using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using CustomRendererSample;
using CustomRendererSample.Droid;
using Android.App;
using Android.Views;

[assembly: ExportRenderer(typeof(PageExample),typeof(CustomPageLayoutRenderer))]
namespace CustomRendererSample.Droid
{
	public class CustomPageLayoutRenderer : PageRenderer
	{
		Activity activity;
		global::Android.Views.View view;

		protected override void OnElementChanged (ElementChangedEventArgs<Page> e)
		{
			base.OnElementChanged (e);

			if (e.OldElement != null || Element == null) {
				return;
			}

			try {
				GetInterface();
				AddView (view);
			} catch (Exception ex) {
				System.Diagnostics.Debug.WriteLine (@"     ERROR: ", ex.Message);
			}
		}
		// Layout from Resources->layout->CustomLayout.axml
		void GetInterface ()
		{
			activity = this.Context as Activity;
			// th
			view = activity.LayoutInflater.Inflate (Resource.Layout.CustomLayout, this, false);
		}


		protected override void OnLayout (bool changed, int l, int t, int r, int b)
		{
			base.OnLayout (changed, l, t, r, b);

			var msw = MeasureSpec.MakeMeasureSpec (r - l, MeasureSpecMode.Exactly);
			var msh = MeasureSpec.MakeMeasureSpec (b - t, MeasureSpecMode.Exactly);

			view.Measure (msw, msh);
			view.Layout (0, 0, r - l, b - t);
		}
	}
}

