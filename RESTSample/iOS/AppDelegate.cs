using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Xamarin.Forms;
using TK.CustomMap.iOSUnified;
using Xamarin;

namespace RESTSample.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		//UIWindow window;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			//global::Xamarin.Forms.Forms.Init ();

			//LoadApplication (new App ());

			//return base.FinishedLaunching (app, options);

			Forms.Init();
			var dummy = new TKCustomMapRenderer();
			var dummy2 = new NativePlacesApi();
			FormsMaps.Init();
			LoadApplication(new App());
			return base.FinishedLaunching(app, options);
		}
	}
}

