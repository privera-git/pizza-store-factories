using System;
using System.Collections.Generic;

namespace Factories.Problem
{
    internal class GreekPizza : Pizza
    {
        public GreekPizza()
        {
            Name = "Cheese Pizza";
            Dough = "Bread Dough";
            Sauce = "Tomato Sauce";

            Toppings = new List<string>
            {
                "Mozzarella Cheese",
                "Tomato",
                "Olive"
            };
        }

        public override void Bake()
        {
            Console.WriteLine("Bake for 10 minutes in a pan");
        }
    }
}