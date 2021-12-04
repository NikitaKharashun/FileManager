using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Nikita_FileManager.Elements
{
    class FileActions
    {
        public static void Actions()
        {
            Console.WriteLine("Выберите действие: \n| 1 - Удалить файл \n| 2 - Удалить все найденные файлы \n| 3 - Удалить диапазон файлов");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Введите имя файла с расширением: ");
                string fileChoise = Console.ReadLine();

                foreach (var file in FileSearcher.Files)
                {
                    if (fileChoise.Equals(file.Value.Name))
                        file.Value.Delete();
                }  

            }

            else if (input == "2")
            {
                foreach (var file in FileSearcher.Files)
                    file.Value.Delete();
            }

            else if (input == "3")
            {
                Console.WriteLine("Введите стартовый файл:");
                int.TryParse(Console.ReadLine(), out int from);

                Console.WriteLine("Введите конечный файл:");
                int.TryParse(Console.ReadLine(), out int to);

                for (;  from <= to; to++)               
                    FileSearcher.Files.Remove(to);                
            }
        }
    }
}