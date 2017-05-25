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
    public partial class Kamus4_1 : PhoneApplicationPage
    {
        SpeechSynthesizer _synthesizer;

        public Kamus4_1()
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
                if (jenis == "bapak")
                {
                    nama1.Content = "bapak";
                    nama2.Content = "bapa";
                    nama3.Content = "romo";
                }
                else if (jenis == "ibu")
                {
                    nama1.Content = "emak";
                    nama2.Content = "simbok";
                    nama3.Content = "biyung";
                }
                else if (jenis == "kakek-nenek")
                {
                    nama1.Content = "embah";
                    nama2.Content = "simbah";
                    nama3.Content = "eyang";
                }
                else if (jenis == "paman")
                {
                    nama1.Content = "pakdhe";
                    nama2.Content = "pakdhe";
                    nama3.Content = "pakdhe";
                }
                else if (jenis == "bibi")
                {
                    nama1.Content = "budhe";
                    nama2.Content = "budhe";
                    nama3.Content = "budhe";
                }
                else if (jenis == "kakak perempuan")
                {
                    nama1.Content = "embak";
                    nama2.Content = "mbakyu";
                    nama3.Content = "mbakyu";
                }
                else if (jenis == "kakak laki-laki")
                {
                    nama1.Content = "kangmas";
                    nama2.Content = "jene";
                    nama3.Content = "kencana";
                }
                else if (jenis == "adik")
                {
                    nama1.Content = "adhi";
                    nama2.Content = "adhi";
                    nama3.Content = "rayi";
                }
                else if (jenis == "saya")
                {
                    nama1.Content = "aku";
                    nama2.Content = "kula";
                    nama3.Content = "kula";
                }
                else if (jenis == "istri")
                {
                    nama1.Content = "bojo";
                    nama2.Content = "istri";
                    nama3.Content = "garwa";
                }
                else if (jenis == "pembantu")
                {
                    nama1.Content = "batur";
                    nama2.Content = "batur";
                    nama3.Content = "rencang";
                }
                else if (jenis == "anak")
                {
                    nama1.Content = "anak";
                    nama2.Content = "putra";
                    nama3.Content = "lare";
                }
                _image.Source = new BitmapImage(new Uri("Assets/keluarga/" + jenis + ".png", UriKind.Relative));
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