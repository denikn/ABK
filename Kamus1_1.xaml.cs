using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using Windows.Foundation;
using Windows.Phone.Speech.Recognition;
using Windows.Phone.Speech.Synthesis;
using System.Windows.Documents;
using ABK.Resources;

namespace ABK
{
    public partial class Kamus1_1 : PhoneApplicationPage
    {
        SpeechSynthesizer _synthesizer;

        public Kamus1_1()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            try
            {
                // Create the speech recognizer and speech synthesizer objects. 
                if (_synthesizer == null)
                {
                    _synthesizer = new SpeechSynthesizer();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }

            string jenis = "";
            bool makanan_ada = NavigationContext.QueryString.TryGetValue("id", out jenis);

            if (makanan_ada)
            {
                nama.Text = jenis;
                if (jenis == "alis") {
                    nama1.Content = "alis";
                    nama2.Content = "alis";
                    nama3.Content = "imba";
                }
                else if(jenis == "gigi"){
                    nama1.Content = "untu";
                    nama2.Content = "untu";
                    nama3.Content ="waja";
                }
                else if(jenis == "hidung"){
                    nama1.Content = "irung";
                    nama2.Content = "irung";
                    nama3.Content = "grana";
                }
                else if(jenis == "kaki") {
                    nama1.Content = "sikil";
                    nama2.Content = "suku";
                    nama3.Content = "ampeyan";
                }
                else if(jenis == "kepala"){
                    nama1.Content = "endhas";
                    nama2.Content = "sirah";
                    nama3.Content = "mustaka";
                }
                else if(jenis == "kumis"){
                    nama1.Content = "brengos";
                    nama2.Content = "brengos";
                    nama3.Content = "rawis";
                }
                else if(jenis == "mata"){
                    nama1.Content = "mata";
                    nama2.Content ="mripat";
                    nama3.Content ="paningal";
                }
                else if(jenis == "mulut"){
                    nama1.Content = "cangkem";
                    nama2.Content = "cangkem";
                    nama3.Content = "tutuk";
                }
                else if(jenis == "perut"){
                    nama1.Content = "weteng";
                    nama2.Content = "weteng";
                    nama3.Content = "padharan";
                }
                else if(jenis == "rambut"){
                    nama1.Content = "rambut";
                    nama2.Content = "rambut";
                    nama3.Content = "rikma";
                }
                else if(jenis == "tangan"){
                    nama1.Content = "tangan";
                    nama2.Content = "tangan";
                    nama3.Content = "asta";
                }
                else if(jenis == "telinga"){
                    nama1.Content = "kuping";
                    nama2.Content = "kuping";
                    nama3.Content = "talingan";
                }
                _image.Source = new BitmapImage(new Uri("Assets/Kamus/bagian tubuh speech/" + jenis + ".png", UriKind.Relative));
            }
            base.OnNavigatedTo(e);
        }

        private async void nama1c(object sender, RoutedEventArgs e)
        {
            try
            {
                await _synthesizer.SpeakTextAsync(nama1.Content.ToString());
            }
            catch (System.Threading.Tasks.TaskCanceledException)
            {
            }
        }

        private async void nama2c(object sender, RoutedEventArgs e)
        {
            try
            {
                await _synthesizer.SpeakTextAsync(nama2.Content.ToString());
            }
            catch (System.Threading.Tasks.TaskCanceledException)
            {
            }
        }

        private async void nama3c(object sender, RoutedEventArgs e)
        {
            try
            {
                await _synthesizer.SpeakTextAsync(nama3.Content.ToString());
            }
            catch (System.Threading.Tasks.TaskCanceledException)
            {
            }
        }
    }
}