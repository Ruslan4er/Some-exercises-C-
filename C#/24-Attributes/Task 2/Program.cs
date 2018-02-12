using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        class MyClass
        {
            [Obsolete("Метод устарел")]
            public void ObsoleteMessage()
            {
                Console.WriteLine("Hello world!");
            }

            [Obsolete("Метод не используется", true)]
            public void ObsoleteError()
            {
                Console.WriteLine("Hello world!");
            }

        }

        static void Main(string[] args)
        {
            var instance = new MyClass();
            instance.ObsoleteMessage();
            
        }
    }
}
