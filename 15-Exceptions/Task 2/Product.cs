using System;

namespace Task_2
{
    public class Product
    {
        private Price[] products;
        public Product()
        {
            FillArray(2);
        }


        private void FillArray(int count)
        {
            products = new Price[count];
            products[0] = new Price("Milk", "Evroopt", 2);
            products[1] = new Price("Bread", "Evroopt", 2);
        }

        public string this[string shop]
        {

            get
            {
                try
                {
                    string result = null; ;
                    foreach (var product in products)
                    {
                        if (product.Shop == shop)
                        {
                            result += product.Name + "\n";
                        }
                    }
                    if (result == null)
                        throw new Exception();

                    return result;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Такого магазина нет");
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

    }
}