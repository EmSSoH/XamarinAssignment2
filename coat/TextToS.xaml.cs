using Plugin.TextToSpeech;
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
    public partial class TextToS : ContentPage
    {
        public TextToS()
        {
            InitializeComponent();
        }


        private void Speak(object sender, EventArgs e)
        {
            CrossTextToSpeech.Current.Speak(form.Text);
        }
    }
}