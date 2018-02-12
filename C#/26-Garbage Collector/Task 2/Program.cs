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
        class MyClass
        {
            private byte[] myByte = new byte[100000];
        }

        static void Main(string[] args)
        {
            //ResourceMonitor monitor = new ResourceMonitor(1000*1024);
            Timer timer = new Timer(new ResourceMonitor(1000 * 1024).CheckRecources,"Memory is full!!",0,20); 

            for (int i = 0; i < 100; i++)
            {
                new MyClass();
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
