using System;
using Xamarin.Forms;
using DependencyServiceSample.Droid;
using System.Threading.Tasks;
using Android.Locations;
using System.Linq;

[assembly: Dependency(typeof(ReverseGeoCode_Android))]
namespace DependencyServiceSample.Droid
{
	public class ReverseGeoCode_Android : IReverseGeoCode
	{
		public ReverseGeoCode_Android ()
		{
		}

		// Task that recieves the passed-in values lat and lon and convert it to its corresponding string text
		public async Task <LocationAddress>ReverseGeoCodeLatLonAsync(double lat, double lon)
		{
			var geo = new Geocoder (Forms.Context);
			var addresses = await geo.GetFromLocationAsync (lat,lon,1);
			if (addresses.Any ()) {
				var place = new LocationAddress ();
				var add = addresses [0];
				place.Name = add.FeatureName;
				if (add.MaxAddressLineIndex > 0) {
					place.Address1 = add.GetAddressLine (0);
				}
				place.City = add.Locality;
				place.Province = add.AdminArea;
				place.ZipCode = add.PostalCode;
				place.Country = add.CountryCode;
				return place;
			}

			return null;
		}
	}
}

