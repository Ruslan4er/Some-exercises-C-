using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2__cloning
{
    class House
    {
        private string _type;
        private int _cost;

        public House()
        {
            Type = "Blocking";
            Cost = 2222;
        }
        public House(string type, int cost)
        {
            Type = type;
            Cost = cost;
        }

        public int Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }


        public House Clone()
        {
            return this as House;
        }

        public House DeepClone()
        {
            return new House(Type,Cost);
        }

    }
}
