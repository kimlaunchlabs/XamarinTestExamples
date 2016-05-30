using System;
using System.Threading.Tasks;

namespace RESTSample
{
	public class GetWeatherItemManager
	{
		IRestServices restService;

		public GetWeatherItemManager (IRestServices service)
		{
			restService = service;
		}

		public Task <RootObjectWeather> GetWeatherAsync (string location)
		{
			string ab = location;

			return restService.GetWeatherDataAsync (ab);
		}
	}
}

