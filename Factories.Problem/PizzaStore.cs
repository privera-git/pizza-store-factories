using System;
using System.Collections.Generic;
using System.Text;

namespace Factories.Problem
{
    public class PizzaStore
    {
        public Pizza OrderPizza(string type)
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

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
