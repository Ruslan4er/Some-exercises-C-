using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory(2);

            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(factory[year]);
            Console.ReadKey();
        }
    }
}
