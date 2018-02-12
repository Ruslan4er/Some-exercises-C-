using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_System_Collections
{
    class Shop
    {
        private NameValueCollection shop;


        public Shop()
        {
            shop = new NameValueCollection
            {
                {"Продукты", "Алеся"},
                {"Продукты", "Макс"},
                {"Продукты", "Антон"},
                {"Перефирия", "Алеся"},
                {"Электроника", "Макс"},
                {"Косметика", "Антон"}
            };
        }

        public void Add(string key, string value)
        {
            shop.Add(key, value);
        }


        public string[] FindAllPeopels(string key)
        {
            return shop.GetValues(key);
        }

       
    }
}
