using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Arrays
{
    class Store
    {
        private Article[] articles = new Article[5] { new Article(), new Article(), new Article(), new Article(), new Article() };


        public Article this[int index]
        {
            get
            {
                return articles[index];
            }
            set
            {
                articles[index] = value;
            }
        }

        public string this[string goodName]
        {
            get
            {
                for (int i = 0; i < articles.Length; i++)
                {
                    if (articles[i].GoodName == goodName)
                        return articles[i].GoodName + " " + articles[i].ShopName + " "
                            + articles[i].Cost;
                }
                return "Товара нет на складе";
            }
        }
    }
}
