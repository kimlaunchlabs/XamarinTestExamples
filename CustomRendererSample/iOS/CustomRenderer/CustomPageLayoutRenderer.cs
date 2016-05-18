using System;
using CustomRendererSample.iOS;
using CustomRendererSample;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using CoreGraphics;

[assembly: ExportRenderer(typeof(PageExample), typeof(CustomPageLayoutRenderer))]
namespace CustomRendererSample.iOS
{
	public class CustomPageLayoutRenderer : PageRenderer
	{
		UILabel testLabel;
		UIButton testButton;

		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged (e);

			if (e.OldElement != null || Element == null) {
				return;
			}

			try {
				GetInterface();
				View.Add(testLabel);
				View.Add(testButton);
			} catch (Exception ex) {
				System.Diagnostics.Debug.WriteLine (@"     ERROR: ", ex.Message);
			}
		}

		void GetInterface ()
		{
			testLabel = new UILabel (new CGRect(110,227,200,30));
			testLabel.Text = "This page was rendered";
			testLabel.TextColor = UIColor.Red;

			testButton = UIButton.FromType(UIButtonType.System);
			testButton.SetTitle ("Button", UIControlState.Normal);
			testButton.Frame = new CGRect(5, 350, 200, 51);
			testButton.BackgroundColor = UIColor.Blue;
			testButton.TintColor = UIColor.White;
			testButton.Font = UIFont.FromName("Helvetica-Bold", 16f);
		}
	}
}

