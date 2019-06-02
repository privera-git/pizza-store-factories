using System;
using System.Collections.Generic;
using System.Text;

namespace Factories.FactoryMethod
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type == "cheese")
            {
                pizza = new ChicagoStyleCheesePizza();
            }
            else if (type == "greek")
            {
                pizza = new ChicagoStyleGreekPizza();
            }
            else if (type == "pepperoni")
            {
                pizza = new ChicagoStylePepperoniPizza();
            }

            return pizza;
        }
    }
}
