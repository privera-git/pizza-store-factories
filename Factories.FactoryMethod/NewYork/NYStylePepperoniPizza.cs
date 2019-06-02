using System.Collections.Generic;

namespace Factories.FactoryMethod
{
    internal class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza()
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