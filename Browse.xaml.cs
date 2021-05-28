using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LibraryApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Browse : Page
    {

        private Frame navigation;

        public Browse()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            PaneHolder.Children.Clear();
            PutPanes();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            navigation = e.Parameter as Frame;
        }

        public void PutPanes()
        {
            Persistence p = Persistence.GetInstance();
            if (p.ScanPathExists())
                p.Scan();

            Pane pane;
            foreach (Video video in p.Videos)
            {
                pane = new Pane(video);
                PaneHolder.Children.Add(pane);
            }
        }

    }
}
