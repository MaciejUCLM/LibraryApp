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

        public static string ReadTextFile(string name)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Videos", name);
            return File.ReadAllText(path);
        }

        public string ScanPath { get; set; }

        private Persistence()
        {
        }

        public bool ScanPathExists() => Directory.Exists(ScanPath);

        public void Scan()
        {
            if (!ScanPathExists())
                ScanPath = Path.Combine(Environment.CurrentDirectory, "Videos");
            // throw new DirectoryNotFoundException("The specified library location has not been found");
            List<string> files = new List<string>(Directory.GetFiles(ScanPath));
            files.FindAll(x => x.EndsWith(".txt"));
        }
    }
}
