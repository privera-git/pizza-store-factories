using System.Collections.Generic;

namespace Factories.Problem
{
    internal class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            Name = "Cheese Pizza";
            Dough = "Thin Dough";
            Sauce = "Tomato Sauce";

            Toppings = new List<string>
            {
                "Mozzarella Cheese"
            };
        }
    }
}