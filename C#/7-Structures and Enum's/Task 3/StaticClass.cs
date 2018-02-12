using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Structures_and_Enum_s
{
    static class StaticClass
    {
        
        public static void Print(string stroka, int color)
        {
            switch (color)
            {
                case (int)Colors.Black:
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case (int)Colors.Blue:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case (int)Colors.Red:
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                default:
                    break;
            }

            Console.WriteLine(stroka);
        }
    }
}
