using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LibraryApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Browse : Page
    {
        public Browse()
        {
            this.InitializeComponent();
            PutPanes();
        }

        public void PutPanes()
        {
            TempTextBlock.Text += "Starting..." + "\n";
            TempTextBlock.Text += "\n";
            // USE PERSISTENCE CLASS FOR THIS - NOT IMPLEMENTED YET - MACIEK
        }

        public static T CloneXaml<T>(T source)
        {
            EmptyPane pane = new EmptyPane();
            return default;
        }

    }
}
