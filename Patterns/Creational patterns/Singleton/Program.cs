using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer();
            Console.WriteLine("Компьютер 1");
            comp.Launch("Windows 8.1");
            Console.WriteLine(comp.Os.Name);

            // у нас не получится изменить ОС, так как объект уже создан    
            comp.Os = OS.GetOs("Windows 10");
            Console.WriteLine(comp.Os.Name);

            Computer comp2 = new Computer();
            comp2.Launch("Windows 10");
            Console.WriteLine(comp2.Os.Name);

            Console.ReadLine();
        }
    }
}
