using System.Collections.Generic;

namespace Factories.Problem
{
    internal class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            Name = "Cheese Pizza";
            Dough = "Thin Dough";
            Sauce = "Tomato Sauce";

            Toppings = new List<string>
            {
                "Mozzarella Cheese",
                "Pepperoni"
            };
        }
    }
}