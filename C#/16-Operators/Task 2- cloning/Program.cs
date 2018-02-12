using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2__cloning
{
    class Program
    {
        static void Main(string[] args)
        {

            House house1 = new House();
            House house2 = new House();
            House house3 = house1.Clone();
            House house4 = house2.DeepClone();

            house1.Cost = 22;
            house2.Cost = 23;

            Console.WriteLine(house1.Cost);
            Console.WriteLine(house2.Cost);
            Console.WriteLine(house3.Cost);
            Console.WriteLine(house4.Cost);

            Console.ReadKey();


        }
    }
}
