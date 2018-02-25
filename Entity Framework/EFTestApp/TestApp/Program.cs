using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Console = System.Console;

namespace TestApp
{
    class MyClass
    {
        static MyClass()
        {
            Console.WriteLine("Static base");
        }

        public MyClass()
        {
            Console.WriteLine("Base");
        }
    }

    class MyClass1 : MyClass
    {
        static MyClass1()
        {
            Console.WriteLine("Static derived ");
        }

        public MyClass1()
        {
            Console.WriteLine("Derived");
        }
    }




    class Program
    {

        static void Main(string[] args)
        {
            MyClass my = new MyClass1();
            
        }


    }

}
