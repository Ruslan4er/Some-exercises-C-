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
        static void Method1()
        {
            Thread.CurrentThread.IsBackground = false;
            Console.WriteLine("Метод 1 начал выполняться");
            Thread.Sleep(1000);
            Console.WriteLine("Метод 1 закончил выполняться");
        }

        static void Method2()
        {
            Thread.CurrentThread.IsBackground = false;
            Console.WriteLine("Метод 2 начал выполняться");
            Thread.Sleep(2000);
            Console.WriteLine("Метод 2 закончил выполняться");
        }


        static void Main()
        {
            Console.WriteLine("Основной поток запущен.");
            
            Task.Factory.StartNew(() => Parallel.Invoke(Method1, Method2));
            
            Console.WriteLine("Основной поток завершен.");
            Console.ReadKey();
        }
    }
}
