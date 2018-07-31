using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Creational_patterns;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Logistics log = new SeaLogistics();
            var prod1 = log.CreateTransport("Рыба");

            log = new RoadLogistics();
            var prod2 = log.CreateTransport("Мясо");

            Console.ReadKey();
        }
    }
}
