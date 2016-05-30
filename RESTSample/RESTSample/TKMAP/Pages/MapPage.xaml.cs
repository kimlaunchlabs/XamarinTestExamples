using System;
using System.Collections.Generic;

using Xamarin.Forms;
using TK.CustomMap;
using Xamarin.Forms.Maps;
using System.ComponentModel;

namespace RESTSample
{
	public partial class MapPage : ContentPage
	{
		double thisLatitude;
		double thisLongitude;

		public MapPage (double lat, double longi)
		{
			InitializeComponent ();

			this.thisLatitude = lat;
			this.thisLongitude = longi;

			this.CreateView (thisLatitude,thisLongitude);
			this.BindingContext = new MapPageViewModel (thisLatitude,thisLongitude);
		}

		private void CreateView(double lat, double longi)
		{
			var autoComplete = new PlacesAutoComplete { ApiToUse = PlacesAutoComplete.PlacesApi.Native };
			autoComplete.SetBinding(PlacesAutoComplete.PlaceSelectedCommandProperty, "PlaceSelectedCommand");

			var newYork = new Position(lat,longi);
			var mapView = new TKCustomMap(MapSpan.FromCenterAndRadius(newYork, Distance.FromKilometers(2)));
			mapView.SetBinding(TKCustomMap.CustomPinsProperty, "Pins");
			mapView.SetBinding(TKCustomMap.MapClickedCommandProperty, "MapClickedCommand");
			mapView.SetBinding(TKCustomMap.MapLongPressCommandProperty, "MapLongPressCommand");
			mapView.SetBinding(TKCustomMap.MapCenterProperty, "MapCenter");
			mapView.SetBinding(TKCustomMap.PinSelectedCommandProperty, "PinSelectedCommand");
			mapView.SetBinding(TKCustomMap.SelectedPinProperty, "SelectedPin");
			mapView.SetBinding(TKCustomMap.RoutesProperty, "Routes");
			mapView.SetBinding(TKCustomMap.PinDragEndCommandProperty, "DragEndCommand");
			mapView.SetBinding(TKCustomMap.CirclesProperty, "Circles");
			mapView.SetBinding(TKCustomMap.CalloutClickedCommandProperty, "CalloutClickedCommand");
			mapView.SetBinding(TKCustomMap.PolylinesProperty, "Lines");
			mapView.SetBinding(TKCustomMap.PolygonsProperty, "Polygons");
			mapView.SetBinding(TKCustomMap.MapRegionProperty, "MapRegion");
			mapView.SetBinding(TKCustomMap.RouteClickedCommandProperty, "RouteClickedCommand");
			mapView.SetBinding(TKCustomMap.RouteCalculationFinishedCommandProperty, "RouteCalculationFinishedCommand");
			mapView.SetBinding(TKCustomMap.TilesUrlOptionsProperty, "TilesUrlOptions");
			mapView.SetBinding(TKCustomMap.MapFunctionsProperty, "MapFunctions");
			mapView.IsRegionChangeAnimated = true;

			autoComplete.SetBinding(PlacesAutoComplete.BoundsProperty, "MapRegion");

			this._baseLayout.Children.Add(
				mapView,
				Constraint.RelativeToView(autoComplete, (r, v) => v.X),
				Constraint.RelativeToView(autoComplete, (r, v) => autoComplete.HeightOfSearchBar),
				heightConstraint: Constraint.RelativeToParent((r) => r.Height - autoComplete.HeightOfSearchBar),
				widthConstraint: Constraint.RelativeToView(autoComplete, (r, v) => v.Width));

			this._baseLayout.Children.Add(
				autoComplete,
				Constraint.Constant(0),
				Constraint.Constant(0));

		}
	}
}

