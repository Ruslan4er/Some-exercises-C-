using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_2
{
    public delegate int simpleDelegate();
    public delegate int anonDelegate(simpleDelegate[] simpleDelegateArr);


    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива");
            int n = int.Parse(Console.ReadLine());

            simpleDelegate[] SDArray = new simpleDelegate[n];

            for (var i = 0; i < SDArray.Length; i++)
                SDArray[i] = new simpleDelegate(RndMethod);

            anonDelegate anonDelegate = SDArr =>
            {
                var sum = 0;
                foreach (var deleg in SDArray)
                    sum += deleg();
                return sum / 10;
            };

            Console.WriteLine(anonDelegate(SDArray));
            Console.ReadKey();

        }

        public static int RndMethod()
        {
            return rnd.Next(1, 200);
        }

    }



}

