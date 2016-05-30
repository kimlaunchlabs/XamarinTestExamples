using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using TK.CustomMap.Droid;
using Android.OS;
using Xamarin.Forms.Platform.Android;
using System.Net;

namespace RESTSample.Droid
{
	[Activity (Label = "RESTSample.Droid", Theme="@style/MyTheme", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			//ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, errors) => true;

			global::Xamarin.Forms.Forms.Init (this, bundle);

			ToolbarResource = Resource.Layout.toolbar;
			TabLayoutResource = Resource.Layout.tabs;

			Xamarin.FormsMaps.Init(this, bundle);
			LoadApplication(new App());
		}
	}
}

