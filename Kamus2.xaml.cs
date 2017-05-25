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
    public partial class Kamus2 : PhoneApplicationPage
    {
        private String jenis = "";

        public Kamus2()
        {
            InitializeComponent();
        }

        private void id1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "desa";
            NavigationService.Navigate(new Uri("/Kamus2_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "gereja";
            NavigationService.Navigate(new Uri("/Kamus2_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id3(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "hutan";
            NavigationService.Navigate(new Uri("/Kamus2_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id4(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "jalan";
            NavigationService.Navigate(new Uri("/Kamus2_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id5(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "joglo";
            NavigationService.Navigate(new Uri("/Kamus2_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id6(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "makam";
            NavigationService.Navigate(new Uri("/Kamus2_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id7(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "masjid";
            NavigationService.Navigate(new Uri("/Kamus2_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id8(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "pasar";
            NavigationService.Navigate(new Uri("/Kamus2_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id9(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "rumah sakit";
            NavigationService.Navigate(new Uri("/Kamus2_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id10(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "rumah";
            NavigationService.Navigate(new Uri("/Kamus2_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id11(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "sekolah";
            NavigationService.Navigate(new Uri("/Kamus2_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id12(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "taman";
            NavigationService.Navigate(new Uri("/Kamus2_1.xaml?id=" + jenis, UriKind.Relative));
        }
    }
}