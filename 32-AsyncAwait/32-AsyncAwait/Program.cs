using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _32_AsyncAwait
{
    class Program
    {
        private static int counter;
        private static object block = new object();

        static async void AsyncMethod()
        {
            Console.WriteLine("Первая часть метода в потоке {0}", Thread.CurrentThread.ManagedThreadId);
            await Task.Run(() =>
            {
                lock (block)
                {
                    for (int i = 0; i < 10; i++)
                        Console.WriteLine(++counter);
                    Console.WriteLine("Вторая часть метода в потоке {0}",
                        Thread.CurrentThread.ManagedThreadId);
                }
            });
        }

        static void Main()
        {
            for (int i = 0; i < 3; i++)
                AsyncMethod();

            Console.ReadKey();

        }
    }
}
