using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_patterns
{
    public abstract class Logistics
    {
        public void SomethingImportant()
        {
            Console.WriteLine("Привет");
        }
        public abstract Product CreateTransport(string name);
    }


    public class RoadLogistics : Logistics
    {
        public override Product CreateTransport(string name)
        {
            return new RoadProduct(name);
        }
    }

    public class SeaLogistics : Logistics
    {
        public override Product CreateTransport(string name)
        {
            return new SeaProduct(name);
        }
    }
}
