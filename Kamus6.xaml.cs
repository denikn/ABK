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
    public partial class Kamus6 : PhoneApplicationPage
    {
        private string jenis = "";

        public Kamus6()
        {
            InitializeComponent();
        }

        private void id1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "satu";
            NavigationService.Navigate(new Uri("/Kamus6_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "dua";
            NavigationService.Navigate(new Uri("/Kamus6_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id3(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "tiga";
            NavigationService.Navigate(new Uri("/Kamus6_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id4(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "empat";
            NavigationService.Navigate(new Uri("/Kamus6_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id5(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "lima";
            NavigationService.Navigate(new Uri("/Kamus6_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id6(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "enam";
            NavigationService.Navigate(new Uri("/Kamus6_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id7(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "tujuh";
            NavigationService.Navigate(new Uri("/Kamus6_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id8(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "delapan";
            NavigationService.Navigate(new Uri("/Kamus6_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id9(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "sembilan";
            NavigationService.Navigate(new Uri("/Kamus6_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id10(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "sepuluh";
            NavigationService.Navigate(new Uri("/Kamus6_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id11(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "sebelas";
            NavigationService.Navigate(new Uri("/Kamus6_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id12(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "dua belas";
            NavigationService.Navigate(new Uri("/Kamus6_1.xaml?id=" + jenis, UriKind.Relative));
        }
    }
}