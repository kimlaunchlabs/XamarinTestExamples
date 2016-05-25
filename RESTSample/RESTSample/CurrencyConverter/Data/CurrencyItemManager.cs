using System;
using System.Threading.Tasks;

namespace RESTSample
{
	public class CurrencyItemManager
	{
		IRestServices restService;

		public CurrencyItemManager (IRestServices service)
		{
			restService = service;
		}

		public Task <RootObject> ConvertAsync()
		{
			return restService.ConvertCurrency ();
		}

//		public Task ConvertCurrency (CurrencyConverterItem CurrItem)
//		{
//			return restService.ConvertCurrencyItemAsync (CurrItem);
//		}
	}
}

