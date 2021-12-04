using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Nikita_FileManager.Elements
{
    class FileSearcher
    {
        public static Dictionary<int, FileInfo> Files { get; set; } = new Dictionary<int, FileInfo>();
        public static int Counter { get; private set; } = 0;

        public static void Searcher(string path, string pattern)
        {
            
            var dir = new DirectoryInfo(path);

            if (dir.Exists)
            {
                foreach (var file in dir.GetFiles(pattern))
                {
                    Counter++;
                    Files.Add(Counter, file);
                }

                foreach (var subdir in dir.GetDirectories())
                    Searcher(subdir.FullName, pattern);
            }

            else
            {
                Console.WriteLine("Заданной директории не существует");
            }
        }
    }
}
