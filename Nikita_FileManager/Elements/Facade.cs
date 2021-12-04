using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_FileManager.Elements
{
    class Facade
    {
        FileSearcher fileSearcher;
        FileActions fileActions;
        ShowInfo showInfo;

        public Facade(FileSearcher fs, FileActions fa, ShowInfo si)
        {
            fileSearcher = fs;
            fileActions = fa;
            showInfo = si;
        }

        public void Operation()
        {
            ShowInfo.Show();
            FileActions.Actions();
        }
    }
}
