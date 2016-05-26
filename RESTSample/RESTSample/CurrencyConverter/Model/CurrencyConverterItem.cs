using System;
using System.Collections.Generic;

namespace RESTSample
{
	public class CurrencyConverterItem
	{
		public string FromCurrency { get; set;}

		public string ToCurrency { get; set;}

		public double AmountCurrency { get; set;}
	}
		

	// ---------------------------------------------------


	public class Query
	{
		public int count { get; set; }

		public override string ToString ()
		{
			return string.Format ("[Query: count={0}]", count);
		}
	}

	public class USDPHP
	{
		public string fr { get; set; }
		public string id { get; set; }
		public string to { get; set; }
		public double val { get; set; }

		public override string ToString ()
		{
			return string.Format ("[USDPHP: fr={0}, id={1}, to={2}, val={3}]", fr, id, to, val);
		}
	}

	public class Results
	{
		public USDPHP CONVERT { get; set; }

		public override string ToString ()
		{
			return string.Format ("[Results: USD_PHP={0}]", CONVERT);
		}
	}

	public class RootObject
	{
		public Query query { get; set; }
		public Results results { get; set; }

		public override string ToString ()
		{
			return string.Format ("[RootObject: query={0}, results={1}]", query, results);
		}
	}




}

