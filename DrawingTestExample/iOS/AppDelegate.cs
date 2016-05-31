using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
//using NControl.iOS;

namespace DrawingTestExample.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			LoadApplication (new App ());

			return base.FinishedLaunching (app, options);




//			global::Xamarin.Forms.Forms.Init ();
//			Xamarin.FormsMaps.Init();
//			NControlViewRenderer.Init();
//
//			LoadApplication (new App (new ContainerProvider(), (container) => {
//
//				// Register providers
//				container.Register<IImageProvider, ImageProvider>();
//
//			}));
//
//			return base.FinishedLaunching (app, options);
		}
	}
}

