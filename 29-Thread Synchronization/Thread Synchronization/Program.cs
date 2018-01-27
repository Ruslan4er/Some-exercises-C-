using System;
using System.IO;
using System.Threading;

namespace Thread_Synchronization
{
    class Program
    {
        static Semaphore semaphore;

        static void Method(object number)
        {
            semaphore.WaitOne();
            File.AppendAllText("MyTextFile.txt", string.Format("Поток {0} получил доступ к файлу\r\n" , number));
            Console.WriteLine("Поток {0} получил доступ к файлу\n", number);
            Thread.Sleep(500);
            File.AppendAllText("MyTextFile.txt", string.Format("--------->>>>Поток {0} законцил работу\r\n" , number));
            Console.WriteLine("Поток {0} законцил работу\n", number);

            semaphore.Release();
        }

        static void Main(string[] args)
        {
            File.Delete("MyTextFile.txt");
            semaphore = new Semaphore(1, 6, "MySemaphore");
            for (int i = 0; i < 10; i++)
                ThreadPool.QueueUserWorkItem(Method,i);

            Thread.CurrentThread.Join();
        }
    }
}
