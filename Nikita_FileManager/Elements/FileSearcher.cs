﻿using System;
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


        public static void Searcher(string path, string pattern)
        {
            var dir = new DirectoryInfo(path);
            int i = 0;

            foreach (var file in dir.GetFiles(pattern))
            {
                i++;
                Files.Add(i, file);
            }

            foreach (var subdir in dir.GetDirectories())            
                Searcher(subdir.FullName, pattern);            
        }
    }
}