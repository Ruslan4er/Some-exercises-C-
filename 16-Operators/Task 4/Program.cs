using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateClass d1 = new DateClass();
            DateClass d2 = new DateClass(new DateTime(2015, 2, 23));

            DateClass d3 = d2 - d1;

            DateClass d4 = d1 + d2;

            Console.WriteLine("число -{0}, месяц- {1}, год-{2}", 
                d1.Date.Day, d1.Date.Month, d1.Date.Year);
            Console.WriteLine("число -{0}, месяц- {1}, год-{2}",
                d2.Date.Day, d2.Date.Month, d2.Date.Year);
            Console.WriteLine("число -{0}, месяц- {1}, год-{2}",
                d3.Date.Day, d3.Date.Month, d3.Date.Year);
            Console.WriteLine("число -{0}, месяц- {1}, год-{2}",
                d4.Date.Day, d4.Date.Month, d4.Date.Year);

            Console.ReadKey();

        }
    }
}
