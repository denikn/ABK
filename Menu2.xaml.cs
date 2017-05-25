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
    public partial class Menu2 : PhoneApplicationPage
    {
        int i = 1;

        SpeechRecognizer _recognizer;                               // The speech recognition object
        SpeechSynthesizer _synthesizer;   
        IAsyncOperation<SpeechRecognitionResult> _recoOperation;    // Used to canel the current asynchronous speech recognition operation

        bool _recoEnabled = false;                                  // When this is true, we will continue to recognize 
        Dictionary<string, DBNull> _speech;                         // Dictionary of all picture

        public Menu2()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            if (_speech == null)
            {
                _speech = new Dictionary<string, DBNull>();
                _speech.Add("lingguh", null);
                _speech.Add("maca", null);
                _speech.Add("madang", null);
                _speech.Add("mlaku", null);
                _speech.Add("ndelok", null);
                _speech.Add("ngrungokne", null);
                _speech.Add("numpak", null);
                _speech.Add("tangi", null);
                _speech.Add("turu", null);
                _speech.Add("wenehi", null);
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
                MessageBox.Show("Error: " + err.Message);
            }

            base.OnNavigatedTo(e);
        }

        private async void sc(object sender, RoutedEventArgs e)
        {
            if (s.Content == "Ulangi")
            {
                soal.Source = new BitmapImage(new Uri("Assets/dewasa/lingguh.png", UriKind.Relative));
                jawaban.Text = "Yuni lagi _________";
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
                            if (recoResult.Text == "lingguh")
                            {
                                await _synthesizer.SpeakTextAsync("Selamat kamu benar");
                                soal.Source = new BitmapImage(new Uri("Assets/dewasa/maca.png", UriKind.Relative));
                                jawaban.Text = "Ajeng lagi __________";
                                i = 2;
                                _recoEnabled = false;
                                s.Content = "Mulai";
                            }
                        }
                        else if (i == 2)
                        {
                            if (recoResult.Text == "maca")
                            {
                                await _synthesizer.SpeakTextAsync("Selamat kamu benar");
                                soal.Source = new BitmapImage(new Uri("Assets/dewasa/madang.png", UriKind.Relative));
                                jawaban.Text = "Ani lagi __________";
                                _recoEnabled = false;
                                s.Content = "Mulai";
                                i = 3;
                            }
                        }
                        else if (i == 3)
                        {
                            if (recoResult.Text == "madang")
                            {
                                await _synthesizer.SpeakTextAsync("Selamat kamu benar");
                                soal.Source = new BitmapImage(new Uri("Assets/dewasa/mlaku.png", UriKind.Relative));
                                jawaban.Text = "Ani lagi __________";
                                _recoEnabled = false;
                                s.Content = "Mulai";
                                i = 4;
                            }
                        }
                        else if (i == 4)
                        {
                            if (recoResult.Text == "mlaku")
                            {
                                await _synthesizer.SpeakTextAsync("Selamat kamu benar");
                                soal.Source = new BitmapImage(new Uri("Assets/dewasa/ndelok.png", UriKind.Relative));
                                jawaban.Text = "Septi lagi _______ TV";
                                _recoEnabled = false;
                                s.Content = "Mulai";
                                i = 5;
                            }
                        }
                        else if (i == 5)
                        {
                            if (recoResult.Text == "ndelok")
                            {
                                await _synthesizer.SpeakTextAsync("Selamat kamu benar");
                                soal.Source = new BitmapImage(new Uri("Assets/dewasa/ngrungokne.png", UriKind.Relative));
                                jawaban.Text = "Atun lagi ______ radio";
                                _recoEnabled = false;
                                s.Content = "Mulai";
                                i = 6;
                            }
                        }
                        else if (i == 6)
                        {
                            if (recoResult.Text == "ngrungokne")
                            {
                                await _synthesizer.SpeakTextAsync("Selamat kamu benar");
                                soal.Source = new BitmapImage(new Uri("Assets/dewasa/numpak.png", UriKind.Relative));
                                jawaban.Text = "Tono lagi ______ sepeda";
                                _recoEnabled = false;
                                s.Content = "Mulai";
                                i = 7;
                            }
                        }
                        else if (i == 7)
                        {
                            if (recoResult.Text == "numpak")
                            {
                                await _synthesizer.SpeakTextAsync("Selamat kamu benar");
                                soal.Source = new BitmapImage(new Uri("Assets/dewasa/tangi.png", UriKind.Relative));
                                jawaban.Text = "Arip lagi ______ turu";
                                _recoEnabled = false;
                                s.Content = "Mulai";
                                i = 8;
                            }
                        }
                        else if (i == 8)
                        {
                            if (recoResult.Text == "tangi")
                            {
                                await _synthesizer.SpeakTextAsync("Selamat kamu benar");
                                soal.Source = new BitmapImage(new Uri("Assets/dewasa/turu.png", UriKind.Relative));
                                jawaban.Text = "Acong lagi __________";
                                _recoEnabled = false;
                                s.Content = "Mulai";
                                i = 3;
                            }
                        }
                        else if (i == 9)
                        {
                            if (recoResult.Text == "turu")
                            {
                                await _synthesizer.SpeakTextAsync("Selamat kamu benar");
                                soal.Source = new BitmapImage(new Uri("Assets/dewasa/wenehi.png", UriKind.Relative));
                                jawaban.Text = "Agung _______ shodaqoh";
                                _recoEnabled = false;
                                s.Content = "Mulai";
                                i = 10;
                            }
                        }
                        else if (i == 10)
                        {
                            if (recoResult.Text == "wenehi")
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
                        MessageBox.Show("Error: " + err.Message);
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