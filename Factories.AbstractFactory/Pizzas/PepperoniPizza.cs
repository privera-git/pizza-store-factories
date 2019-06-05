using Factories.AbstractFactory.Ingredients;
using System;
using System.Collections.Generic;

namespace Factories.AbstractFactory
{
    internal class PepperoniPizza : Pizza
    {
        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory) : base(ingredientFactory) { }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateChesse();
            Pepperoni = _ingredientFactory.CreatePepperoni();
        }
    }
}