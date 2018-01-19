using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = "D:\\BSUIR\\Курсы\\C#\\Упражнения\\Some-exercises-C-\\20-IO\\Task 2\\bin\\Debug";
            string path = ".";
            string myFile = "Test.txt";
            bool finded = false;
            
            // First variant
            foreach (var file in Directory.GetFileSystemEntries(path))
            {
                if (Path.GetFileName(file) == myFile)
                {
                    Console.WriteLine("Совпадение!!");
                    Console.WriteLine(Path.GetFileName(file));
                    finded = true;
                }
            }
            if (!finded)
                Console.WriteLine("Файл не найден");


            

            Console.ReadKey();
        }


    }
}
