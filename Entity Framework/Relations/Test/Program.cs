using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {

        private Program()
        {
            
        }
        static void Main(string[] args)
        {
            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine(fib(i));
            }
            
            Func<int, int> asd = Fact;
        }

        static int Fact(int n)
        {
            if (n == 0)
                return 1;
            return n * Fact(n - 1);
        }

        static int fib(int n)
        {
            if (n > 1)
                return fib(n - 1) + fib(n - 2);
            return n;
        }
    }
}
