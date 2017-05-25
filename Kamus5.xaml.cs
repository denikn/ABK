using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace ABK
{
    public partial class Kamus5 : PhoneApplicationPage
    {
        private string jenis = "";
        public Kamus5()
        {
            InitializeComponent();
        }

        private void id1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "makan";
            NavigationService.Navigate(new Uri("/Kamus5_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "jalan";
            NavigationService.Navigate(new Uri("/Kamus5_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id3(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "tidur";
            NavigationService.Navigate(new Uri("/Kamus5_1.xaml?id=" + jenis, UriKind.Relative));
        }
    }
}