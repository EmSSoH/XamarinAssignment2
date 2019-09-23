using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace coat
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Shake : ContentPage
	{
        bool flashlight = false;

		public Shake ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            Accelerometer.ShakeDetected += Accelerometer_ShakeDetected;

            Accelerometer.Start(SensorSpeed.Game);
        }

        protected override async void OnDisappearing()
        {
            Accelerometer.ShakeDetected -= Accelerometer_ShakeDetected;

            Accelerometer.Stop();
        }

        private void Accelerometer_ShakeDetected(object sender, EventArgs e)
        {
            if (flashlight == false)
            {
                Flashlight.TurnOnAsync();
                flashlight = true;
            } else
            {
                Flashlight.TurnOffAsync();
                flashlight = false;
            }
        }
    }
}