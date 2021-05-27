using System;
using System.Collections.Generic;
using System.IO;

namespace LibraryApp
{
    class Persistence
    {
        private static Persistence instance = null;
        public static Persistence GetInstance()
        {
            if (instance == null)
                instance = new Persistence();
            return instance;
        }

        private List<Video> mVideos;

        public List<Video> Videos { get; }
        public string ScanPath { get; set; }

        private Persistence()
        {
            ScanPath = Path.Combine(Environment.CurrentDirectory, "Videos");
            mVideos = new List<Video>();
        }

        public string GetFilePath(string name) => Path.Combine(ScanPath, name);

        public bool ScanPathExists() => Directory.Exists(ScanPath);

        public void Scan()
        {
            if (!ScanPathExists())
                ScanPath = Path.Combine(Environment.CurrentDirectory, "Videos");
            // throw new DirectoryNotFoundException("The specified library location has not been found");
            List<string> files = new List<string>(Directory.GetFiles(ScanPath));
            files = files.FindAll(x => x.EndsWith(".json"));
            foreach (var f in files)
            {
                var v = new Video(File.ReadAllText(f));
                mVideos.Add(v);
            }
        }
    }
}
