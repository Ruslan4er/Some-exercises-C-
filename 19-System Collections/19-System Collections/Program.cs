using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_System_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();
            shop.Add("Продукты", "Маруся");

            Console.WriteLine("Продукты покупали:");
            foreach (var value in shop.FindAllPeopels("Продукты"))
            {
                Console.WriteLine(value);
            }
            

            Console.ReadKey();
        }

    }
}

