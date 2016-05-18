using System;
using Xamarin.Forms;

namespace CustomRendererSample
{
	public enum StyleType
	{
		Italic,
		Bold,
		BoldItalic
	}

	public class StyledLabel : Label
	{
		public StyleType styleType { get; set;}
	
	}
}

