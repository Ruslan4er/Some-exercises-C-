using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Garbage_Collector
{
    class BigData : IDisposable
    {
        public byte[] array = new byte[1000000];
        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Финализатор выполнился");
                }
            }
            disposed = true;
        }
        ~BigData()
        {
            Console.WriteLine("Finilize");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            method();
            Console.WriteLine(GC.GetTotalMemory(true) / 1024);
            Console.ReadKey();
        }

        static void method()
        {
            BigData instance = new BigData();
            Console.WriteLine(GC.GetTotalMemory(false) / 1024);
            instance.Dispose();
            instance.Dispose();
        }
    }
}
