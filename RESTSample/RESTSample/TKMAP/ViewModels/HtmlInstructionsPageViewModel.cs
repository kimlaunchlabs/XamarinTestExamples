using System;

using Xamarin.Forms;
using TK.CustomMap.Overlays;
using TK.CustomMap;

namespace RESTSample
{
	public class HtmlInstructionsPageViewModel : TKBase
	{
		public HtmlWebViewSource Instructions { get; private set; }

		public HtmlInstructionsPageViewModel (TKRoute route)
		{
			this.Instructions = new HtmlWebViewSource();
			this.Instructions.Html = @"<html><body>";
			foreach (var s in route.Steps)
			{
				this.Instructions.Html += string.Format("<b>{0}km:</b> {1}<br /><hr />", s.Distance / 1000, s.Instructions);
			}
			this.Instructions.Html += @"</body></html>";
		}
	}
}


