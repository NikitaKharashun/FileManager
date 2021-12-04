using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Nikita_FileManager.Elements
{
    class ShowInfo
    {
        public static void Show()
        {

            FileSearcher.Searcher(@".", "*.txt");

            foreach (var file in FileSearcher.Files)           
                Console.WriteLine(FileSearcher.Files.Count == 0 ? "Таких файлов нет" : $"Имя файла: {file.Value.Name}");
        }
    }
}
