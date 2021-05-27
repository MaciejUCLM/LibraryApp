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
        public Description()
        {
            this.InitializeComponent();
            var img = "ilpadrino.jpg";
            var txt = "ilpadrino.json";
            imageMovie.Source = new BitmapImage(new Uri(Persistence.GetInstance().GetFilePath(img)));
            var text = File.ReadAllText(Persistence.GetInstance().GetFilePath(txt));
            descrTextBlock.Text = text;

        }
    }
}
