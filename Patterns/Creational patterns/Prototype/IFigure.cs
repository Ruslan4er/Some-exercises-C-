using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }


    class Rectangle :IFigure
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width ,int height)
        {
            Width = width;
            Height = height;
        }
        
        public IFigure Clone()
        {
            return new Rectangle(Width,Height);
        }

        public void GetInfo()
        {
            Console.WriteLine("Прямоугольник с длиной {0} и шириной {1}",Width,Height);
        }
    }


    class Circle : IFigure
    {
        public int Radius { get; set; }
       
        public Circle(int radius)
        {

            Radius = radius;
        }

        public IFigure Clone()
        {
            return new Circle(Radius);
        }

        public void GetInfo()
        {
            Console.WriteLine("Окружность с радиусом {0}", Radius);
        }
    }
}
