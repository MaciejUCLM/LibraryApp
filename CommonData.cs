using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace LibraryApp
{
    class CommonData
    {
        private static CommonData instance = null;
        public static CommonData GetInstance()
        {
            if (instance == null)
                instance = new CommonData();
            return instance;
        }

        public Video SelectedVideo = null;
        public Frame NavigationFrame = null;

        private CommonData()
        {
        }
    }
}
