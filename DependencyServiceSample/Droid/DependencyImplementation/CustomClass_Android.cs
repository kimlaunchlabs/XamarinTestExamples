using System;
using Xamarin.Forms;
using DependencyServiceSample.Droid;

// Registering a class for use in Dependency Service
[assembly: Dependency(typeof(CustomClass_Android))]

namespace DependencyServiceSample.Droid
{
 	// Creating platform-specific implementation of ICustomClass interface
	public class CustomClass_Android :  ICustomClass
	{
		public CustomClass_Android ()
		{
		}

		public string GoNative (string param)
		{
			return "Android " + param;
		}
	}
}

