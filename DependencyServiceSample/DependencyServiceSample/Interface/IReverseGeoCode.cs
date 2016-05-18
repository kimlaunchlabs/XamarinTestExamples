using System;
using System.Threading.Tasks;

namespace DependencyServiceSample
{
	// Creating Interface IReverseGeoCode with ReverseGeoCodeLatLonAsync Task 
	public interface IReverseGeoCode
	{
		Task<LocationAddress> ReverseGeoCodeLatLonAsync (double lat, double lon);
	}
}

