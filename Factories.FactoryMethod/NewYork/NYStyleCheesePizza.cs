using System.Collections.Generic;

namespace Factories.FactoryMethod
{
    internal class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            Name = "N Style Sauce and Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";

            Toppings = new List<string>
            {
                "Grated Reggiano Cheese"
            };
        }
    }
}