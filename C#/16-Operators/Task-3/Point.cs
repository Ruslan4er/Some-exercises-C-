using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Point
    {
        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        public Point()
        {
            X = 1;
            Y = 1;
            Z = 4;
        }

        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Point operator +(Point point1, Point point2)
        {
            return new Point(point1.X + point2.X, point1.Y + point2.Y, point1.Z + point2.Z);
        }
    }
}
