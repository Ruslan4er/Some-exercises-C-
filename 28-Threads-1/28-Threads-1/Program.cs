using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _28_Threads_1
{
    class MyClass
    {
        private static int counter;
        private object block = new object();

        public void SomeMethod()
        {
            lock (block)
            {
                for (int i = 0; i < 10; i++)
                {
                    // Interlocked.Increment(ref counter);
                    counter++;
                    Console.WriteLine("Счетчик - {0}, поток № {1}",
                        counter, Thread.CurrentThread.GetHashCode());
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            ThreadStart thread = instance.SomeMethod;
            instance.SomeMethod();

            for (var i = 0; i < 3; i++)
                new Thread(thread).Start();

            Console.ReadKey();
        }
    }
}
