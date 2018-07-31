using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_patterns
{
    public class Product
    {
        private string name;
        public Product(string name)
        {
            this.name = name;
        }

    }

    public class SeaProduct: Product
    {
        public SeaProduct(string name):
            base(name)
        {
            Console.WriteLine("Посылка ({0}) отправлена по морю", name);
        }
    }

    public class RoadProduct: Product
    {
        public RoadProduct(string name) :
            base(name)
        {
            Console.WriteLine("Посылка ({0}) отправлена по суше", name);
        }
    }



}
