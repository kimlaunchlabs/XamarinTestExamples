using System;
using System.Net.Http;
using System.Text;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RESTSample
{
	public class RestService : IRestServices
	{
		HttpClient client;

		public RootObject Items { get; private set;}

		public RestService ()
		{
			var authdata = string.Format ("{0}:{1}", Constants.Username, Constants.Password);
			var authHeaderValue = Convert.ToBase64String (Encoding.UTF8.GetBytes (authdata));

			client = new HttpClient ();
			client.MaxResponseContentBufferSize = 256000;
			client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue ("Basic", authHeaderValue);
		}

		public async Task <RootObject> ConvertCurrency ()
		{
			Items = new RootObject ();
			var uri = new Uri (string.Format(Constants.RestUrl));

			try {
				var response = await client.GetAsync(uri);
				if (response.IsSuccessStatusCode) {
					var content = await response.Content.ReadAsStringAsync();
					//Items = JsonConvert.DeserializeObject<RootObject>(content);

					dynamic jresponse = JsonConvert.DeserializeObject(content);

					System.Diagnostics.Debug.WriteLine(jresponse["USD_PHP"]);
				}
			} catch (Exception e) {
				System.Diagnostics.Debug.WriteLine (@"       Error{0}", e.Message);
			}

			//System.Diagnostics.Debug.WriteLine(Items);
			return Items;

		}

	}
}

