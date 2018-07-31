using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Pizza
    {
        protected Pizza(string n)
        {
            Name = n;
        }

        public string Name { get; protected set; }
        public abstract int GetCost();
    }

    public class ItalianPizza : Pizza
    {
        public ItalianPizza() : base("Итальянская пицца")
        {
        }

        public override int GetCost()
        {
            return 10;
        }
    }

    public class BulgerianPizza : Pizza
    {
        public BulgerianPizza() : base("Болгарская пицца")
        {
        }

        public override int GetCost()
        {
            return 8;
        }
    }


}
