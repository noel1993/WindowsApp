using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using IdeaApp.Resources;

namespace IdeaApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Single_Click(object sender, RoutedEventArgs e)
        {
            // Navigation for single bets
            NavigationService.Navigate(new Uri("/Single_Bet.xaml", UriKind.RelativeOrAbsolute));     
        }

        private void Button_Double_Click(object sender, RoutedEventArgs e)
        {
            // Navigation for double bets
            NavigationService.Navigate(new Uri("/Double_Bet.xaml", UriKind.RelativeOrAbsolute));     
        }

        private void Button_Treble_Click(object sender, RoutedEventArgs e)
        {
            // Navigation for treble bets
            NavigationService.Navigate(new Uri("/Treble_Bet.xaml", UriKind.RelativeOrAbsolute));     
        }

        private void Button_Trixie_Click(object sender, RoutedEventArgs e)
        {
            // Navigation for trixie bets
            NavigationService.Navigate(new Uri("/Trixie_Bet.xaml", UriKind.RelativeOrAbsolute)); 
        }

        private void Button_Yankee_Click(object sender, RoutedEventArgs e)
        {
            // Navigation for yankee bets
            NavigationService.Navigate(new Uri("/Yankee_Bet.xaml", UriKind.RelativeOrAbsolute)); 
        }

    }
}