using System;
using System.Net.Http;
using System.Text;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using System.Dynamic;
using System.Linq;
using System.Collections.Generic;

namespace RESTSample
{
	public class RestService : IRestServices
	{
		HttpClient client;

		public RootObject Items;

		public RootObjectWeather weatherItems;


		public RestService ()
		{
			var authdata = string.Format ("{0}:{1}", Constants.Username, Constants.Password);
			var authHeaderValue = Convert.ToBase64String (Encoding.UTF8.GetBytes (authdata));

			client = new HttpClient ();
			client.MaxResponseContentBufferSize = 256000;
			client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue ("Basic", authHeaderValue);
		}

		public async Task <RootObject> ConvertCurrency (string toCurr, string fromCurr)
		{
			string thisReplace = toCurr + "_" + fromCurr;
			//System.Diagnostics.Debug.WriteLine ("replace " + thisReplace);

			var uri = new Uri (string.Format(Constants.RestUrl) + thisReplace);


			try {
				var response = await client.GetAsync(uri);
				if (response.IsSuccessStatusCode) {
					var content = await response.Content.ReadAsStringAsync();

					var thisContent = content.Replace(thisReplace.ToUpper(), "CONVERT");

					Items = JsonConvert.DeserializeObject<RootObject>(thisContent);
					//var a = Items["results.USD_PHP"].Value<string>();
				}
					
			} catch (Exception e) {
				System.Diagnostics.Debug.WriteLine (@"Error  {0} ", e.Message);
			}
			return Items;
		}

		public async Task <RootObjectWeather> GetWeatherDataAsync (string location)
		{
			string thisLocation = location;

			string apikey = "147a4dedf73ad453d97b7229d819614a";

			var uri = new Uri (string.Format(Constants.RestUrlWeather) + thisLocation + "&apikey=" + apikey);
			//var uri = new Uri (string.Format(Constants.RestUrlWeather));

			try {
				var response = await client.GetAsync(uri);
				if (response.IsSuccessStatusCode) {
					var content = await response.Content.ReadAsStringAsync();
					weatherItems = JsonConvert.DeserializeObject<RootObjectWeather>(content);
				}
			} catch (Exception ex) {
				System.Diagnostics.Debug.WriteLine (@"Error {0} ", ex.Message);
			}

			return weatherItems;
		}

	}
}

