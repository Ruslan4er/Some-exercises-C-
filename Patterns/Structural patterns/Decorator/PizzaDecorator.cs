using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class PizzaDecorator : Pizza
    {
        protected Pizza Pizza { get; set; }

        protected PizzaDecorator(string n, Pizza pizza) : base(n)
        {
            Pizza = pizza;
        }
    }

    class TomatoPizza : PizzaDecorator
    {
        public TomatoPizza(Pizza p) : base(p.Name + ", с томатами", p)
        {
        }

        public override int GetCost()
        {
            return Pizza.GetCost() + 3;
        }
    }

    class CheesePizza : PizzaDecorator
    {
        public CheesePizza(Pizza pizza) : base(pizza.Name + ", c сыром", pizza)
        {
        }

        public override int GetCost()
        {
            return Pizza.GetCost() + 5;
        }
    }
}
