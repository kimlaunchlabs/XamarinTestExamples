using System;
using Xamarin.Forms;
using DependencyServiceSample.iOS;
using System.Threading.Tasks;
using CoreLocation;
using System.Linq;

[assembly: Dependency(typeof(ReverseGeoCode_iOS))]
namespace DependencyServiceSample.iOS
{
	public class ReverseGeoCode_iOS: IReverseGeoCode
	{
		public ReverseGeoCode_iOS ()
		{
		}

		// Task that recieves the passed-in values lat and lon and convert it to its corresponding string text
		public async Task <LocationAddress> ReverseGeoCodeLatLonAsync(double lat, double lon)
		{
			var geoCoder = new CLGeocoder ();
			var location = new CLLocation (lat, lon);
			var placemarks = await geoCoder.ReverseGeocodeLocationAsync (location);
			if (placemarks.Any ()) {
				var place = new LocationAddress ();
				var pm = placemarks [0];
				place.Name = pm.Name;
				place.City = pm.Locality;
				place.Province = pm.AdministrativeArea;
				place.ZipCode = pm.PostalCode;
				place.Country = pm.IsoCountryCode;
				return place;
			}

			return null;
		}
	}
}

