using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Store stores = new Store();

            stores[0].GoodName = "Мясо";
            stores[0].ShopName = "Зарина";
            stores[0].Cost = 16;

            stores[2].GoodName = "Молоко";
            stores[2].ShopName = "Соседи";
            stores[2].Cost = 2;

            stores[4].GoodName = "Хлопья";
            stores[4].ShopName = "Рублевский";
            stores[4].Cost = 1;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Товар: " + stores[i].GoodName);
                Console.WriteLine("Магазин: " + stores[i].ShopName);
                Console.WriteLine("Цена: " + stores[i].Cost);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("Проверьте если товар на складе. Введите название товара:");
            string goodName = Console.ReadLine();
            Console.WriteLine(stores[goodName]);

            Console.ReadKey();
        }
    }
}
