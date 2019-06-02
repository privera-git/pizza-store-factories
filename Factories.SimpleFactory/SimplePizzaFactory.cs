using System;
using System.Collections.Generic;
using System.Text;

namespace Factories.SimpleFactory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type == "cheese")
            {
                pizza = new CheesePizza();
            }
            else if (type == "greek")
            {
                pizza = new GreekPizza();
            }
            else if (type == "pepperoni")
            {
                pizza = new PepperoniPizza();
            }

            return pizza;
        }
    }
}
