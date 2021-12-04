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
            FileSearcher.Files.Clear();
            FileSearcher.Searcher(@".", "*.txt");       

            foreach (var file in FileSearcher.Files)           
                Console.WriteLine(FileSearcher.Files.Count.Equals(0)? "Файлы не найдены" : $"Номер: {file.Key} Имя файла: {file.Value.Name}");
        }
    }
}
