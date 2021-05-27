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
            Persistence p = Persistence.GetInstance();
            if (p.ScanPathExists())
                p.Scan();
            
            foreach (Video video in p.Videos)
            {
                Pane pane = new Pane();
                
            }

            // USE PERSISTENCE CLASS FOR THIS - NOT IMPLE
            // MENTED YET - MACIEK
        }

        public static T CloneXaml<T>(T source)
        {
            Pane pane = new Pane();
            return default;
        }

    }
}
