using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Video
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Image { get; set; } = "";
        public string Path { get; set; } = "";

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
                }
            }
        }
    }
}
