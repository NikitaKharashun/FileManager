using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nikita_FileManager.Elements;

namespace Nikita_FileManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new Facade(new FileSearcher(), new FileActions(), new ShowInfo());

            facade.Operation();

            Console.ReadKey();
        }
    }
}
