using System;
using MapKit;

namespace CustomRendererSample.iOS
{
	public class CustomMKPinAnnotationView : MKPinAnnotationView
	{
		public string Id { get; set; }

		public string Url { get; set; }

		public CustomMKPinAnnotationView (IMKAnnotation annotation, string id) : base (annotation, id)
		{
			
		}

	}
}

