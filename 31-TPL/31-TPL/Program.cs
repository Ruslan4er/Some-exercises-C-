using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _31_TPL
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] myList = new int[100000000];
            //List<int> myList = new List<int>();
            Stopwatch timer = new Stopwatch();

            timer.Start();
            for (int i = 0; i < 100000000; i++)
            {
                myList[i] = rnd.Next(1, 500);
                //myList.Add(rnd.Next(1, 500));
            }
            timer.Stop();
            Console.WriteLine("Массив инициализировался - {0} сек", timer.Elapsed);
            timer.Reset();

            #region Параллельная выборка
            GC.Collect();
            timer.Start();
            var result = from element in myList.AsParallel()
                         where element % 2 == 0
                         select element;
            timer.Stop();
            Console.WriteLine("Параллальная выборка - {0} сек, количество- {1}", timer.Elapsed, result.Count());
            timer.Reset();
            #endregion

            #region Обычная выборка
            GC.Collect();
            timer.Start();
            var result1 = from e in myList
                          where e % 2 == 0
                          select e;
            timer.Stop();
            Console.WriteLine("Обычная выборка - {0} сек, количество- {1}", timer.Elapsed, result1.Count());
            timer.Reset();
            #endregion
        }
    }
}

