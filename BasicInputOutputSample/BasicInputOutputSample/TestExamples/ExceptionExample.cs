using System;

using Xamarin.Forms;

namespace BasicInputOutputSample
{
	public class ExceptionExample : ContentPage
	{
		public ExceptionExample ()
		{
			int x = 0;

			for (int i = 0; i<=1; i++)
			{
				try {
					int y = 100/x;
					System.Diagnostics.Debug.WriteLine ("Value of Y is: " + y);
				//} catch (ArithmeticException e) {
				//	System.Diagnostics.Debug.WriteLine ("ArthmeticException Handler: {0}", e.ToString());
				} 
				catch (Exception e) {
					System.Diagnostics.Debug.WriteLine ("Generic Exception Handler: {0} ", e.ToString());
				} finally {
					// here's the fix
					x = 2;
				}
			}
		}
	}
}


