using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Arrays
{
    class Article
    {
        private string _goodName;
        private string _shopName;
        private int _cost;

        public Article()
        {
            _goodName = "Хлеб";
            _shopName = "Евроопт";
            _cost = 2;
        }

        public string GoodName
        {
            get { return _goodName; }
            set { _goodName = value; }
        }

        public string ShopName
        {
            get { return _shopName; }
            set { _shopName = value; }
        }
        public int Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }
    }
}
