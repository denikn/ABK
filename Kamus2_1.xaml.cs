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
    public partial class Kamus2_1 : PhoneApplicationPage
    {
        SpeechSynthesizer _synthesizer;

        public Kamus2_1()
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
                if (jenis == "desa")
                {
                    nama1.Content = "desa";
                    nama2.Content = "dhusun";
                    nama3.Content = "dhusun";
                }
                else if (jenis == "gereja")
                {
                    nama1.Content = "gereja";
                    nama2.Content = "gereja";
                    nama3.Content = "gereja";
                }
                else if (jenis == "hutan")
                {
                    nama1.Content = "alas";
                    nama2.Content = "wana";
                    nama3.Content = "wana";
                }
                else if (jenis == "jalan")
                {
                    nama1.Content = "dalan";
                    nama2.Content = "radin";
                    nama3.Content = "margi";
                }
                else if (jenis == "joglo")
                {
                    nama1.Content = "joglo";
                    nama2.Content = "joglo";
                    nama3.Content = "joglo";
                }
                else if (jenis == "makam")
                {
                    nama1.Content = "kuburan";
                    nama2.Content = "sareyan";
                    nama3.Content = "pasareyan";
                }
                else if (jenis == "masjid")
                {
                    nama1.Content = "mejid";
                    nama2.Content = "mejid";
                    nama3.Content = "mejid";
                }
                else if (jenis == "pasar")
                {
                    nama1.Content = "pasar";
                    nama2.Content = "pasar";
                    nama3.Content = "peken";
                }
                else if (jenis == "rumah sakit")
                {
                    nama1.Content = "rumah sakit";
                    nama2.Content = "rumah sakit";
                    nama3.Content = "rumah sakit";
                }
                else if (jenis == "rumah")
                {
                    nama1.Content = "omah";
                    nama2.Content = "dalem";
                    nama3.Content = "griya";
                }
                else if (jenis == "sekolah")
                {
                    nama1.Content = "sekolah";
                    nama2.Content = "sekolah";
                    nama3.Content = "sekolah";
                }
                else if (jenis == "taman")
                {
                    nama1.Content = "kebon";
                    nama2.Content = "kebon";
                    nama3.Content = "kebon";
                }
                _image.Source = new BitmapImage(new Uri("Assets/tempat/" + jenis + ".png", UriKind.Relative));
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