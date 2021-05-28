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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace LibraryApp
{
    public sealed partial class Category : UserControl
    {

        private string Name = "";

        public Category()
        {
            this.InitializeComponent();
        }

        public Category(string name) : this()
        {
            SetText(name);
        }

        public void SetText(string name)
        {
            if (name == "")
                name = "Others";
            CategoryTextBlock.Text = name;
            Name = name;
        }

        public void addChild(Pane child)
        {
            CategoryPanel.Children.Add(child);
        }

        public UIElementCollection GetChildren()
        {
            return CategoryPanel.Children;
        }

        public string GetName() => Name;
    }
}
