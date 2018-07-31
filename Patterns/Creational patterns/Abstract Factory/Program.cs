using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var room = new Room(new VictorianFurnitureFactory());

            Console.WriteLine("___________________________________");
            var room2 = new Room(new ModernFurnitureFactory());

            Console.WriteLine("___________________________________");

            FurnitureFactory factory = new VictorianFurnitureFactory();
            factory.CreateChair();
            factory.CreateСoffeTable();
            factory= new ModernFurnitureFactory();
            factory.CreateSofa();


            Console.ReadKey();

        }
    }
}
