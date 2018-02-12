using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> dictionary = new Dictionary<int,string>(3);
            dictionary.AddPair(1,"One");
            dictionary.AddPair(2, "Two");
            dictionary.AddPair(3, "Three");
            dictionary.AddPair(4, "Four");

            Console.WriteLine("Введите индекс пары");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(dictionary[index]);

            Console.WriteLine("Количество элементов:{0}",dictionary.Count);
            
            
            Console.ReadKey();

        }
    }
}
