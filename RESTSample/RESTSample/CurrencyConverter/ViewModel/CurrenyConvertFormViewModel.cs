using System;

using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace RESTSample
{
	public class CurrenyConvertFormViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		//String tempBalor = "";

		public CurrenyConvertFormViewModel ()
		{
			var currItem = new CurrencyConverterItem ();
			FromCurrency = currItem.FromCurrency;
			ToCurrency = currItem.ToCurrency;
			AmountCurrency = currItem.AmountCurrency;
			//Balor = tempBalor;
		}

		private string from_Currency;
		public string FromCurrency
		{
			get {
				return from_Currency;
			} 
			set {
				from_Currency = value;
				OnPropertyChanged ();
			}
		}

		private string to_Currency;
		public string ToCurrency
		{
			get {
				return to_Currency;
			}
			set {
				to_Currency = value;
				OnPropertyChanged ();
			}
		}

		private double amount_Currency;
		public double AmountCurrency
		{
			get {
				return amount_Currency;
			}
			set {
				amount_Currency = value;
				OnPropertyChanged ();
			}
		}

		private string balor;
		public string Balor
		{
			get {
				return balor;
			}
			set {
				balor = value;
				OnPropertyChanged ();
			}
		}

		public ICommand Convert
		{
			get {
				return new Command (async() => {
					try {
						var a = await App.currManager.ConvertAsync(FromCurrency,to_Currency);

						System.Diagnostics.Debug.WriteLine("Final " + a.results.CONVERT.val);
						 
						string toString = a.results.CONVERT.val.ToString();

						Balor = toString;

					} catch (Exception ex) {
						System.Diagnostics.Debug.WriteLine(ex.Message + " + " + "Input Error");
						Balor = ex.Message + "    OR It is an Invalid Input";
					}
				});
			}
		}

		public void OnPropertyChanged ([CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) {
				handler (this, new PropertyChangedEventArgs (propertyName));
			}
		}

	}
}


