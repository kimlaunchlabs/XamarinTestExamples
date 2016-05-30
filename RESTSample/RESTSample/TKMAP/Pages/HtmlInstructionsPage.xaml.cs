using System;
using System.Collections.Generic;

using Xamarin.Forms;
using TK.CustomMap.Overlays;

namespace RESTSample
{
	public partial class HtmlInstructionsPage : ContentPage
	{
		public HtmlInstructionsPage (TKRoute route)
		{
			InitializeComponent ();

			this.BindingContext = new HtmlInstructionsPageViewModel(route);
		}
	}
}

