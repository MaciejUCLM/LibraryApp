using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace LibraryApp
{
    public class Video
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Image { get; set; } = "";
        public string Path { get; set; } = "";
        public string Category { get; set; } = "";
        public string Age { get; set; } = "";
        public string Director { get; set; } = "";
        public string Rating { get; set; } = "";
        public string Release { get; set; } = "";

        public Video(string json)
        {
            string[] fields = json.Split('"', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 1; i < fields.Length; i+=4)
            {
                switch (fields[i])
                {
                    case "title":
                        Title = fields[i + 2];
                        break;
                    case "desc":
                        Description = fields[i + 2];
                        break;
                    case "image":
                        Image = Persistence.GetInstance().GetFilePath(fields[i + 2]);
                        break;
                    case "video":
                        Path = Persistence.GetInstance().GetFilePath(fields[i + 2]);
                        break;
                    case "category":
                        Category = fields[i + 2];
                        break;
                    case "age":
                        Age = fields[i + 2];
                        break;
                    case "director":
                        Director = fields[i + 2];
                        break;
                    case "rating":
                        Rating = fields[i + 2];
                        break;
                    case "release":
                        Release = fields[i + 2];
                        break;
                }
            }
        }

        public ImageSource GetImage() => new BitmapImage(new Uri(Image));
    }
}
