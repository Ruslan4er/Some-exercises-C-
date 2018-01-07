using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    public delegate int Delegate(int n1, int n2, int n3);
    public delegate int Delegat(int n1, int n2);

    class Program
    {
        static int a = 32;
        static int b = 22;
        static int c = 76;
        static void Main(string[] args)
        {

            Delegate average = (n1, n2, n3) => (n1 + n2 + n3) / 3;

            Delegat add = (n1, n2) => n1 + n2;
            Delegat sub = (n1, n2) => n1 - n2;
            Delegat mul = (n1, n2) => n1 * n2;
            Delegat div = (n1, n2) => n1 / n2;

            Console.WriteLine("Выберите операцию");
            var choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите первое число");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            var b = int.Parse(Console.ReadLine());



            switch (choice)
            {
                case 1:
                    Console.WriteLine(add(a, b));
                    break;
                case 2:
                    Console.WriteLine(sub(a, b));
                    break;
                case 3:
                    Console.WriteLine(mul(a, b));
                    break;
                case 4:
                    if (b == 0)
                    {
                        Console.WriteLine("Деление на ноль!");
                        break;
                    }
                    Console.WriteLine(div(a, b));
                    break;
            }
            
            Console.ReadKey();
        }



    }
}
