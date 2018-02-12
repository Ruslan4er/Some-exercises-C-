using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Custom_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Year year = new Year();

            foreach (string month in year)
            {
                Console.Write(month+" ");
            }
            Console.WriteLine();

            Console.WriteLine("Месяц номер 4 - {0}",year[4]);

            string[] result = year.FindMonth(31);

            Console.WriteLine("Месяцы, где 31 день:");
            foreach (var month in result)
            {
                Console.Write(month+" ");
            }

            Console.ReadKey();

        }
    }
}
