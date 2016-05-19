using System;

using Xamarin.Forms;

namespace SliderSample
{
	public class SliderBasicExercise : ContentPage
	{
		Label textLabel;
		Label rotationSliderZLabel;
		Label rotationSliderXLabel;
		Label rotationSliderYLabel;

		public SliderBasicExercise ()
		{
			// Label
			textLabel = new Label () { Text = "TEXT", FontSize = 35, FontAttributes = FontAttributes.Bold, HorizontalOptions = LayoutOptions.Center };

			// Rotation Z
			var rotationSliderZ = new Slider { Minimum = 0, Maximum = 180, VerticalOptions = LayoutOptions.Center };
			rotationSliderZ.ValueChanged += OnSliderValueChangedZ;
			rotationSliderZLabel = new Label () { Text = "Rotation Z "};

			// Rotation X
			var rotationSliderX = new Slider { Minimum = 0, Maximum = 180, VerticalOptions = LayoutOptions.Center };
			rotationSliderX.ValueChanged += OnSliderValueChangedX;
			rotationSliderXLabel = new Label () { Text = "Rotation X "};

			// Rotation Y
			var rotationSliderY = new Slider { Minimum = 0, Maximum = 180, VerticalOptions = LayoutOptions.Center };
			rotationSliderY.ValueChanged += OnSliderValueChangedY;
			rotationSliderYLabel = new Label () { Text = "Rotation Y "};

			var sliderStack = new StackLayout () {
				//HorizontalOptions = LayoutOptions.Center,
				//VerticalOptions = LayoutOptions.Center,
				Children = {
					rotationSliderZ,
					rotationSliderZLabel,
					rotationSliderX,
					rotationSliderXLabel,
					rotationSliderY,
					rotationSliderYLabel }
			};

			var myStack = new StackLayout () {
				Padding = new Thickness (10,0,10,0),
				Spacing = 60,
				Children = {textLabel, sliderStack},
				VerticalOptions = LayoutOptions.Center
			};

			Content = myStack;
		}

		void OnSliderValueChangedZ (object sender, ValueChangedEventArgs e)
		{
			textLabel.Rotation = e.NewValue;
			rotationSliderZLabel.Text = "Rotation Z " + e.NewValue.ToString();
		}

		void OnSliderValueChangedX (object sender, ValueChangedEventArgs e)
		{
			textLabel.RotationX = e.NewValue;
			rotationSliderXLabel.Text = "Rotation X " + e.NewValue.ToString();
		}

		void OnSliderValueChangedY (object sender, ValueChangedEventArgs e)
		{
			textLabel.RotationY = e.NewValue;
			rotationSliderYLabel.Text = "Rotation Y " + e.NewValue.ToString();

		}
	}
}


