using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_FileManager.Elements
{
    class Facade
    {
        private FileSearcher fileSearcher ;
        private FileActions fileActions;
        private ShowInfo showInfo;

        public Facade(FileSearcher fs, FileActions fa, ShowInfo si)
        {
            fileSearcher = fs;
            fileActions = fa;
            showInfo = si;
        }

        public static void Operation()
        {
            ShowInfo.Show();
            FileActions.Actions();
        }
    }
}
