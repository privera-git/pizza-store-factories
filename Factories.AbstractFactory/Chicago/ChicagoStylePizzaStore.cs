using Factories.AbstractFactory.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factories.AbstractFactory.Chicago
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            if (type == "cheese")
            {
                pizza = new CheesePizza(ingredientFactory)
                {
                    Name = "Chicago Style Cheese Pizza"
                };
            }
            else if (type == "veggie")
            {
                pizza = new VeggiePizza(ingredientFactory)
                {
                    Name = "Chicago Style Veggie Pizza"
                };
            }
            else if (type == "clam")
            {
                pizza = new ClamPizza(ingredientFactory)
                {
                    Name = "Chicago Style Clam Pizza"
                };
            }
            else if (type == "pepperoni")
            {
                pizza = new PepperoniPizza(ingredientFactory)
                {
                    Name = "Chicago Style Pepperoni Pizza"
                };
            }

            return pizza;
        }
    }
}
