using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.AddPair(1, "One");
            dictionary.AddPair(2, "Two");
            dictionary.AddPair(3, "Three");
            dictionary.AddPair(4, "Four");

            Console.WriteLine("Введите ключ ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(dictionary[index]);

            Console.WriteLine("Количество элементов:{0}", dictionary.Count);


            foreach (string value in dictionary)
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }
    }
}
