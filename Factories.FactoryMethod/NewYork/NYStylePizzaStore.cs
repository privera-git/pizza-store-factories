using System;
using System.Collections.Generic;
using System.Text;

namespace Factories.FactoryMethod
{
    public class NYStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type == "cheese")
            {
                pizza = new NYStyleCheesePizza();
            }
            else if (type == "greek")
            {
                pizza = new NYStyleGreekPizza();
            }
            else if (type == "pepperoni")
            {
                pizza = new NYStylePepperoniPizza();
            }

            return pizza;
        }
    }
}
