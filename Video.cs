using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Video
    {
        public string Title { get; set; }
        public string Path { get; set; }

        public Video(string title, string path)
        {
            Title = title;
            Path = path;
        }
    }
}
