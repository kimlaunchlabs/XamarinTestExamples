using System;
using Xamarin.Forms;
using DependencyServiceSample.iOS;

// Registering a class for use in Dependency Service
[assembly: Dependency(typeof(CustomClass_iOS))]

namespace DependencyServiceSample.iOS
{
	// Creating platform-specific implementation of ICustomClass interface
	public class CustomClass_iOS : ICustomClass
	{
		public CustomClass_iOS ()
		{
		}

		public string GoNative (string param)
		{
			return "iOS " + param;
		}
	}
}

