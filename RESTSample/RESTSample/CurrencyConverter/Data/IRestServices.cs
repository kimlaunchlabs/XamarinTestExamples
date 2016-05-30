using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace RESTSample
{
	public interface IRestServices
	{
		Task <RootObject> ConvertCurrency (string toCurr, string fromCurr);

		Task <RootObjectWeather> GetWeatherDataAsync (string location);
	}
}

