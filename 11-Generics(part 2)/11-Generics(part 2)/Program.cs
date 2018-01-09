using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Generics_part_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<object> carCollection = new CarCollection<object>();

            carCollection.AddCar("BMW",new DateTime(1996,1,23));
            carCollection.AddCar("Audi",new DateTime(2001,2,9));
            carCollection.AddCar("Mercedes",new DateTime(1999,2,4));


            Console.WriteLine("Первая машина - {0}",carCollection[0]);
            
            Console.WriteLine("Всего машин:{0}",carCollection.Count);

            carCollection.ClearCars();



            Console.ReadKey();
        }
    }
}
