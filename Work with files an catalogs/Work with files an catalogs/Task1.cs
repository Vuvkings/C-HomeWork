using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Work_with_files_an_catalogs
{
    public class Task1
    {
        public string DirName { get; set; }
        public Task1 (string dirName) 
        {
            DirName = dirName;
        }
        public void AddCatalog() {
            if (Directory.Exists(DirName))
            {
                Console.WriteLine("Каталог уже создан");
            }
            else
            {
                Console.WriteLine("Create new catalog");
                Directory.CreateDirectory(DirName);
            }
        }
        public void RemoveCatalog() 
        {
            DirectoryInfo dirInfo = new DirectoryInfo(DirName);
            if (dirInfo.Exists)
            {
                dirInfo.Delete(true);
                Console.WriteLine("Каталог удален");
            }
            else
            {
                Console.WriteLine("Каталога не существует");
            }
        }
    }
}
