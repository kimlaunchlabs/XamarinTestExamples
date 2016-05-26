using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace RESTSample
{
	public class CurrencyItemManager
	{
		IRestServices restService;

		public CurrencyItemManager (IRestServices service)
		{
			restService = service;
		}

		public Task <RootObject> ConvertAsync(string toCurr, string fromCurr)
		{
			string a = toCurr;
			string b = fromCurr;
			return restService.ConvertCurrency (a, b);
		}
			
	}
}

