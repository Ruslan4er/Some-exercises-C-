using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ThreadState = System.Diagnostics.ThreadState;

namespace _13_Threads
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 42);

            Matrix instance;
            
            for (int i = 0; i < 26; i++)
            {
                instance = new Matrix(i * 3, true);
                new Thread(instance.Move).Start();
            }
            Console.ReadKey();
        }
    }
}
