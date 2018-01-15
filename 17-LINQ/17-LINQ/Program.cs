using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
           var autos = new List<Auto>
            {
                new Auto("Audi", "TT", 2015, "green"),
                new Auto(),
                new Auto("Porche", "911", 2012, "yellow"),
                new Auto()
            };

            var customers = new List<Customer>
            {
                new Customer(),
                new Customer(),
                new Customer("TT","Andrew","+23214124124"),
                new Customer("TT","Chak","+123124124"),
                new Customer("911","Andrew","+123124124"),
            };

            string custName = "Andrew";

            var fullInformation = from customer in customers

                                  where customer.CustomerName == custName 
                                  join auto in autos on customer.Model equals auto.Model
                                  select new
                                  {
                                      Name = customer.CustomerName,
                                      PhoneNumber = customer.PhoneNumber,
                                      Model = customer.Model,
                                      Color = auto.Color,
                                      Mark = auto.Mark,
                                      Year = auto.Year
                                  };



            foreach (var item in fullInformation)
            {
                Console.WriteLine("Автомобиль модели {0}, марки {1} {2} цвета {3} года, принадлежит {4} с номером {5}",
                    item.Model,item.Mark,item.Color,item.Year,item.Name,item.PhoneNumber);
            }

            Console.ReadKey();



        }
    }
}
