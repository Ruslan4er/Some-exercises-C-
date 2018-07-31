using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();

            HouseBuilder builder = new RichHouseBuilder();
            var house = director.BuildHouse(builder);

            builder = new CheapHouseBuilder();
            var house2 = director.BuildHouse(builder);
            
            Console.WriteLine("Дом с {0} стенами, {1} дверью и {2} окнами",house.Walls.Type,house.Door.Type,house.Windows.Count);
            Console.WriteLine("_____________________________________");
            Console.WriteLine("Дом с {0} стенами, {1} дверью и {2} окнами",house2.Walls.Type,house2.Door.Type,house2.Windows.Count);
        }
    }
}
