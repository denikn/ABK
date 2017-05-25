using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Windows.Phone.Speech.Recognition;
using Windows.Phone.Speech.Synthesis;
using ABK.Resources;
using Windows.Foundation;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Documents;

namespace ABK
{
    public partial class Menu1 : PhoneApplicationPage
    {
        int i = 1;

        SpeechRecognizer _recognizer;                               // The speech recognition object
        SpeechSynthesizer _synthesizer;
        IAsyncOperation<SpeechRecognitionResult> _recoOperation;    // Used to canel the current asynchronous speech recognition operation

        bool _recoEnabled = false;                                  // When this is true, we will continue to recognize 
        Dictionary<string, DBNull> _speech;                         // Dictionary of all picture

        public Menu1()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            if (_speech == null)
            {
                _speech = new Dictionary<string, DBNull>();
                _speech.Add("lenggah", null);
                _speech.Add("maos", null);
                _speech.Add("dhahar", null);
                _speech.Add("mlampah", null);
                _speech.Add("mirsani", null);
                _speech.Add("mirengake", null);
                _speech.Add("niti", null);
                _speech.Add("wungu", null);
                _speech.Add("sare", null);
                _speech.Add("nyaosi", null);
            }

            try
            {
                if (_synthesizer == null)
                {
                    _synthesizer = new SpeechSynthesizer();
                }
                if (_recognizer == null)
                {
                    _recognizer = new SpeechRecognizer();
                    // Set up a list of colors to recognize.
                    _recognizer.Grammars.AddGrammarFromList("Speech", _speech.Keys);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Error 1: " + err.Message);
            }

            base.OnNavigatedTo(e);
        }

        private async void sc(object sender, RoutedEventArgs e)
        {
            if (s.Content.ToString() == "Ulangi")
            {
                soal.Source = new BitmapImage(new Uri("Assets/anak/lingguh.png", UriKind.Relative));
                jawaban.Text = "Bapak nembe _________";
                i = 1;
            }
            if (this._recoEnabled)
            {
                _recoEnabled = false;
                s.Content = "Mulai";
                if (_recoOperation != null && _recoOperation.Status == AsyncStatus.Started)
                {
                    _recoOperation.Cancel();
                }
                return;
            }
            else
            {
                _recoEnabled = true;
                s.Content = "Berhenti";
            }
            while (this._recoEnabled)
            {
                try
                {
                    // Perform speech recognition.  
                    _recoOperation = _recognizer.RecognizeAsync();
                    var recoResult = await this._recoOperation;

                    // Check the confidence level of the speech recognition attempt.
                    if (recoResult.TextConfidence < SpeechRecognitionConfidence.Medium)
                    {
                        // If the confidence level of the speech recognition attempt is low, 
                        // ask the user to try again.
                        await _synthesizer.SpeakTextAsync("Coba Lagi");
                    }
                    else
                    {
                        if (i == 1)
                        {
                            if (recoResult.Text == "lenggah")
                            {
                                await _synthesizer.SpeakTextAsync("Selamat kamu benar");
                                soal.Source = new BitmapImage(new Uri("Assets/anak/maca.png", UriKind.Relative));
                                jawaban.Text = "Pakdhe nembe __________";
                                i = 2;
                                _recoEnabled = false;
                                s.Content = "Mulai";
                            }
                        }
                        else if (i == 2)
                        {
                            if (recoResult.Text == "maos")
                            {
                                await _synthesizer.SpeakTextAsync("Selamat kamu benar");
                                soal.Source = new BitmapImage(new Uri("Assets/anak/madang.png", UriKind.Relative));
                                jawaban.Text = "Paklek nembe __________";
                                _recoEnabled = false;
                                s.Content = "Mulai";
                                i = 3;
                            }
                        }
                        else if (i == 3)
                        {
                            if (recoResult.Text == "dhahar")
                            {
                                await _synthesizer.SpeakTextAsync("Selamat kamu benar");
                                soal.Source = new BitmapImage(new Uri("Assets/anak/mlaku.png", UriKind.Relative));
                                jawaban.Text = "Bapak nembe __________";
                                _recoEnabled = false;
                                s.Content = "Mulai";
                                i = 4;
                            }
                        }
                        else if (i == 4)
                        {
                            if (recoResult.Text == "mlampah")
                            {
                                await _synthesizer.SpeakTextAsync("Selamat kamu benar");
                                soal.Source = new BitmapImage(new Uri("Assets/anak/ndelok.png", UriKind.Relative));
                                jawaban.Text = "Bapak nembe _______ TV";
                                _recoEnabled = false;
                                s.Content = "Mulai";
                                i = 5;
                            }
                        }
                        else if (i == 5)
                        {
                            if (recoResult.Text == "mirsani")
                            {
                                await _synthesizer.SpeakTextAsync("Selamat kamu benar");
                                soal.Source = new BitmapImage(new Uri("Assets/anak/ngrungokne.png", UriKind.Relative));
                                jawaban.Text = "Ibu nembe ______ radio";
                                _recoEnabled = false;
                                s.Content = "Mulai";
                                i = 6;
                            }
                        }
                        else if (i == 6)
                        {
                            if (recoResult.Text == "mirengake")
                            {
                                await _synthesizer.SpeakTextAsync("Selamat kamu benar");
                                soal.Source = new BitmapImage(new Uri("Assets/anak/numpak.png", UriKind.Relative));
                                jawaban.Text = "Paklek nembe ______ sepeda";
                                _recoEnabled = false;
                                s.Content = "Mulai";
                                i = 7;
                            }
                        }
                        else if (i == 7)
                        {
                            if (recoResult.Text == "nitih")
                            {
                                await _synthesizer.SpeakTextAsync("Selamat kamu benar");
                                soal.Source = new BitmapImage(new Uri("Assets/anak/tangi.png", UriKind.Relative));
                                jawaban.Text = "Ibu nembe ______ sare";
                                _recoEnabled = false;
                                s.Content = "Mulai";
                                i = 8;
                            }
                        }
                        else if (i == 8)
                        {
                            if (recoResult.Text == "wungu")
                            {
                                await _synthesizer.SpeakTextAsync("Selamat kamu benar");
                                soal.Source = new BitmapImage(new Uri("Assets/anak/turu.png", UriKind.Relative));
                                jawaban.Text = "Ibu nembe __________";
                                _recoEnabled = false;
                                s.Content = "Mulai";
                                i = 3;
                            }
                        }
                        else if (i == 9)
                        {
                            if (recoResult.Text == "sare")
                            {
                                await _synthesizer.SpeakTextAsync("Selamat kamu benar");
                                soal.Source = new BitmapImage(new Uri("Assets/anak/wenehi.png", UriKind.Relative));
                                jawaban.Text = "Bapak _______ shodaqoh";
                                _recoEnabled = false;
                                s.Content = "Mulai";
                                i = 10;
                            }
                        }
                        else if (i == 10)
                        {
                            if (recoResult.Text == "nyaosi")
                            {
                                MessageBox.Show("Selamat Kamu berhasil! Nilai 10 buat kamu :)");
                                _recoEnabled = false;
                                s.Content = "Ulangi";
                            }
                        }
                    }
                }
                catch (System.Threading.Tasks.TaskCanceledException)
                {
                    // Ignore the cancellation exception of the recoOperation.
                    // When recoOperation.Cancel() is called to cancel the asynchronous speech recognition operation
                    // initiated by RecognizeAsync(),  a TaskCanceledException is thrown to signify early exit.
                }
                catch (Exception err)
                {
                    // Handle the speech privacy policy error.
                    const int privacyPolicyHResult = unchecked((int)0x80045509);

                    if (err.HResult == privacyPolicyHResult)
                    {
                        MessageBox.Show("To run this app, you must first accept the speech privacy policy by navigate to Settings --> speech on your phone and check 'Enable Speech Recognition Service' ");
                        _recoEnabled = false;
                        s.Content = "Start";
                    }
                    else
                    {
                        MessageBox.Show("Error 2: " + err.Message);
                    }
                }
            }
        }

        private void _close(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _recoEnabled = false;
        }
    }
}