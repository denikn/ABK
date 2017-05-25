using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace ABK.Assets
{
    public partial class Menu3 : PhoneApplicationPage
    {
        private String jenis = "";

        public Menu3()
        {
            InitializeComponent();
        }

        private void id1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "alis";
            NavigationService.Navigate(new Uri("/Kamus1_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "gigi";
            NavigationService.Navigate(new Uri("/Kamus1_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id3(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "hidung";
            NavigationService.Navigate(new Uri("/Kamus1_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id4(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "kaki";
            NavigationService.Navigate(new Uri("/Kamus1_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id5(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "kepala";
            NavigationService.Navigate(new Uri("/Kamus1_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id6(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "kumis";
            NavigationService.Navigate(new Uri("/Kamus1_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id7(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "mata";
            NavigationService.Navigate(new Uri("/Kamus1_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id8(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "mulut";
            NavigationService.Navigate(new Uri("/Kamus1_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id9(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "perut";
            NavigationService.Navigate(new Uri("/Kamus1_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id10(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "rambut";
            NavigationService.Navigate(new Uri("/Kamus1_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id11(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "tangan";
            NavigationService.Navigate(new Uri("/Kamus1_1.xaml?id=" + jenis, UriKind.Relative));
        }

        private void id12(object sender, System.Windows.Input.GestureEventArgs e)
        {
            jenis = "telinga";
            NavigationService.Navigate(new Uri("/Kamus1_1.xaml?id=" + jenis, UriKind.Relative));
        }
    }
}