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
    public partial class Kamus5_1 : PhoneApplicationPage
    {
        SpeechSynthesizer _synthesizer;

        public Kamus5_1()
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

            n.Text = jenis;

            if (makanan_ada)
            {
                nama.Text = jenis;
                if (jenis == "makan")
                {
                    nama1.Content = "madhang";
                    nama2.Content = "nedha";
                    nama3.Content = "dhahar";
                }
                else if (jenis == "jalan")
                {
                    nama1.Content = "mlaku";
                    nama2.Content = "mlampah";
                    nama3.Content = "mlampah";
                }
                else if (jenis == "tidur")
                {
                    nama1.Content = "turu";
                    nama2.Content = "tilem";
                    nama3.Content = "sare";
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