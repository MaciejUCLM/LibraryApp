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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace LibraryApp
{
    public sealed partial class Pane : UserControl
    {

        private Video video;

        public Pane()
        {
            this.InitializeComponent();
        }

        public Pane(Video video) : this()
        {
            this.video = video;
            SetImage(video.GetImage());
            SetText(video.Description);
        }

        public void SetImage(ImageSource image)
        {
            PaneImage.Source = image;
        }

        public void SetText(string text)
        {
            PaneTextBlock.Text = text;
        }

        private void GoToDescription(object sender, RoutedEventArgs e)
        {
            CommonData.GetInstance().SelectedVideo = video;
            CommonData.GetInstance().NavigationFrame.Navigate(typeof(Description));
        }
    }
}
