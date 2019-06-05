using Factories.AbstractFactory.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factories.AbstractFactory.NewYork
{
    public class NYStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (type == "cheese")
            {
                pizza = new CheesePizza(ingredientFactory)
                {
                    Name = "New York Style Cheese Pizza"
                };
            }
            else if (type == "veggie")
            {
                pizza = new VeggiePizza(ingredientFactory)
                {
                    Name = "New York Style Veggie Pizza"
                };
            }
            else if (type == "clam")
            {
                pizza = new ClamPizza(ingredientFactory)
                {
                    Name = "New York Style Clam Pizza"
                };
            }
            else if (type == "pepperoni")
            {
                pizza = new PepperoniPizza(ingredientFactory)
                {
                    Name = "New York Style Pepperoni Pizza"
                };
            }

            return pizza;
        }
    }
}
