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
    public partial class Kamus4 : PhoneApplicationPage
    {
        private string jenis = "";
        public Kamus4()
        {
            InitializeComponent();
        }

        private void id1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "adik";
            NavigationService.Navigate(new Uri("/Kamus4_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "anak";
            NavigationService.Navigate(new Uri("/Kamus4_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id3(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "bapak";
            NavigationService.Navigate(new Uri("/Kamus4_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id4(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "bibi";
            NavigationService.Navigate(new Uri("/Kamus4_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id5(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "ibu";
            NavigationService.Navigate(new Uri("/Kamus4_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id6(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "istri";
            NavigationService.Navigate(new Uri("/Kamus4_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id7(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "kakak laki-laki";
            NavigationService.Navigate(new Uri("/Kamus4_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id8(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "kakak perempuan";
            NavigationService.Navigate(new Uri("/Kamus4_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id9(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "kakek-nenek";
            NavigationService.Navigate(new Uri("/Kamus4_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id10(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "paman";
            NavigationService.Navigate(new Uri("/Kamus4_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id11(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "pembantu";
            NavigationService.Navigate(new Uri("/Kamus4_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id12(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "saya";
            NavigationService.Navigate(new Uri("/Kamus4_1.xaml?id=" + jenis, UriKind.Relative));
        }
    }
}