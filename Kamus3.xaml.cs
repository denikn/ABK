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
    public partial class Kamus3 : PhoneApplicationPage
    {
        private string jenis = "";

        public Kamus3()
        {
            InitializeComponent();
        }

        private void id1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "lagi";
            NavigationService.Navigate(new Uri("/Kamus3_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "akan";
            NavigationService.Navigate(new Uri("/Kamus3_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id3(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "sudah";
            NavigationService.Navigate(new Uri("/Kamus3_1.xaml?id=" + jenis, UriKind.Relative));
        }
    }
}