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
    public partial class Kamus6_1 : PhoneApplicationPage
    {
        SpeechSynthesizer _synthesizer;

        public Kamus6_1()
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

            nama.Text = jenis;

            if (makanan_ada)
            {
                if (jenis == "satu")
                {
                    n.Text = "1";
                    nama1.Content = "siji";
                    nama2.Content = "setunggal";
                    nama3.Content = "setunggal";
                }
                else if (jenis == "dua")
                {
                    n.Text = "2";
                    nama1.Content = "loro";
                    nama2.Content = "kalih";
                    nama3.Content = "kalih";
                }
                else if (jenis == "tiga")
                {
                    n.Text = "3";
                    nama1.Content = "telu";
                    nama2.Content = "tiga";
                    nama3.Content = "tiga";
                }
                else if (jenis == "empat")
                {
                    n.Text = "4";
                    nama1.Content = "papat";
                    nama2.Content = "sekawan";
                    nama3.Content = "sekawan";
                }
                else if (jenis == "lima")
                {
                    n.Text = "5";
                    nama1.Content = "lima";
                    nama2.Content = "gangsal";
                    nama3.Content = "gangsal";
                }
                else if (jenis == "enam")
                {
                    n.Text = "6";
                    nama1.Content = "enem";
                    nama2.Content = "enem";
                    nama3.Content = "enem";
                }
                else if (jenis == "tujuh")
                {
                    n.Text = "7";
                    nama1.Content = "pitu";
                    nama2.Content = "pitu";
                    nama3.Content = "pitu";
                }
                else if (jenis == "delapan")
                {
                    n.Text = "8";
                    nama1.Content = "wolu";
                    nama2.Content = "wolu";
                    nama3.Content = "wolu";
                }
                else if (jenis == "sembilan")
                {
                    n.Text = "9";
                    nama1.Content = "sanga";
                    nama2.Content = "sanga";
                    nama3.Content = "sanga";
                }
                else if (jenis == "sepuluh")
                {
                    n.Text = "10";
                    nama1.Content = "sepuluh";
                    nama2.Content = "sedasa";
                    nama3.Content = "sedasa";
                }
                else if (jenis == "sebelas")
                {
                    n.Text = "11";
                    nama1.Content = "sewelas";
                    nama2.Content = "sewelas";
                    nama3.Content = "sewelas";
                }
                else if (jenis == "dua belas")
                {
                    n.Text = "12";
                    nama1.Content = "rolas";
                    nama2.Content = "kalih welas";
                    nama3.Content = "kalih welas";
                }
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