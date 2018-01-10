using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___Events
{
    delegate void Deleg();

    class Program
    {
        private static event Deleg sad;
        static void Main(string[] args)
        {
            sad += () => Console.WriteLine("sdas");
            sad();

            int a = int.Parse(Console.ReadLine());

            if (a==1)
                sad();
            Console.ReadKey();
        }



    }
}
