using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LibraryApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MainFrame.Navigate(typeof(Browse), MainFrame);
            Persistence.GetInstance().Scan();
        }

        private void GoToDescription(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Description), MainFrame);
        }

        private void GoToPLayer(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Player), MainFrame);
        }

        private void GoToBrowse(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Browse), MainFrame);
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                MainFrame.GoBack();
            }
        }
    }
}
