using System;
using System.Threading.Tasks;

namespace RESTSample
{
	public interface IRestServices
	{
		Task <RootObject> ConvertCurrency ();

		//Task ConvertCurrencyItemAsync (CurrencyConverterItem CurrItem);
	}
}

