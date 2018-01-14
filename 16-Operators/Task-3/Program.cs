using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point();
            Point point2 = new Point();

            Point point3 = point1 + point2;

            Console.WriteLine("X-{0}, y-{1}, z-{2}", point1.X, point1.Y, point1.Z);
            Console.WriteLine("X-{0}, y-{1}, z-{2}", point2.X, point2.Y, point2.Z);
            Console.WriteLine("X-{0}, y-{1}, z-{2}", point3.X, point3.Y, point3.Z);

            Console.ReadKey();
        }
    }
}
