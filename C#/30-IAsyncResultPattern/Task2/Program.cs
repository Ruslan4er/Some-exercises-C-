using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        private static Func<int, int, int> function;


        static int Add(int x, int y)
        {
            Thread.Sleep(1000);
            return x + y;
            
        }

        static void CallBackMethod (IAsyncResult asyncResult)
        {
            var async = asyncResult as AsyncResult;
            var del = async.AsyncDelegate as Func<int,int,int>;
            Console.WriteLine("Результат: {0}, Доп информация {1}",del.EndInvoke(asyncResult), (string)asyncResult.AsyncState );

        }


        static void Main(string[] args)
        {
            function = Add;
            var callback = new AsyncCallback(CallBackMethod);

            function.BeginInvoke(1, 2, callback, @"---Меня передали вместе с методом---");
            Console.ReadKey();
        }
    }
}
