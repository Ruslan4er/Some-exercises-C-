using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        private static Mutex mutex = new Mutex(false,"MyMutex");

        static void Main(string[] args)
        {
            mutex.WaitOne();
            for (int i = 0; i < 25; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine(i);
            }
            mutex.ReleaseMutex();

        }
    }
}
