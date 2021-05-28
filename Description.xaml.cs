using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
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
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LibraryApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Description : Page
    {
        private Video details;

        public Description()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            SetVideo(CommonData.GetInstance().SelectedVideo);
        }

        public void SetVideo(Video video)
        {
            details = video;
            if (video != null)
            {
                //details.Title
                imageMovie.Source = details.GetImage();
                descrTextBlock.Text = details.Description 
                                      +"\n\nDirector: " +details.Director
                                      +"\n\nRating: " +details.Rating +"/5"
                                      +"\n\nRelease Date: " +details.Release
                                      +"\n\nMininum Age: " +details.Age;
            }
        }

        private void watchButton_Click(object sender, RoutedEventArgs e)
        {
            CommonData.GetInstance().NavigationFrame.Navigate(typeof(Player));
        }
    }
}
