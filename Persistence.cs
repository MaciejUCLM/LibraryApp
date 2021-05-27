using System;
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

        public string ScanPath { get; set; }

        private Persistence()
        {
        }

        public bool ScanPathExists() => Directory.Exists(ScanPath);

        public void Scan()
        {
            if (!ScanPathExists())
                throw new DirectoryNotFoundException("The specified library location has not been found");
            throw new NotImplementedException("Library scanning has not been implemented");
        }
    }
}
