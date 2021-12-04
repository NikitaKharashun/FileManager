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

                try
                {
                    foreach (var file in FileSearcher.Files)
                    {
                        if (fileChoise.Equals(file.Value.Name))
                            file.Value.Delete();
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("Файл успешно удален. Оставшиеся файлы:");
                ShowInfo.Show();
            }


            else if (input == "2")
            {
                try
                {
                    foreach (var file in FileSearcher.Files)                        
                        file.Value.Delete();
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("Файлы успешно удалены.\n Оставшиеся файлы: ");
                ShowInfo.Show();
            }


            else if (input == "3")
            {
                Console.WriteLine("Введите стартовый файл:");
                int.TryParse(Console.ReadLine(), out int startIndex);

                Console.WriteLine("Введите конечный файл:");
                int.TryParse(Console.ReadLine(), out int FinishIndex);

                try
                {
                    for (; startIndex <= FinishIndex; startIndex++)
                        FileSearcher.Files.Remove(startIndex);
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("Файлы успешно удалены.\n Оставшиеся файлы:");
                ShowInfo.Show();
            }

            else
            {
                Console.WriteLine("Действие не распознано");
            }
        }
    }
}