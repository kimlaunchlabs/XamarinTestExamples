using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Xamarin.Forms;

namespace RESTSample.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		UIWindow window;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			//global::Xamarin.Forms.Forms.Init ();

			Forms.Init ();
			window = new UIWindow (UIScreen.MainScreen.Bounds);

			window.RootViewController = App.GetPage().CreateViewController ();
			window.MakeKeyAndVisible ();

			return true;

//			LoadApplication (new App ());
//
//			return base.FinishedLaunching (app, options);
		}
	}
}

