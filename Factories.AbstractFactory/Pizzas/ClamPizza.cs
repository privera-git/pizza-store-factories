using Factories.AbstractFactory.Ingredients;
using System;
using System.Collections.Generic;

namespace Factories.AbstractFactory
{ 
    internal class ClamPizza : Pizza
    {
        public ClamPizza(IPizzaIngredientFactory ingredientFactory) : base(ingredientFactory) { }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateChesse();
            Clam = _ingredientFactory.CreateClam();
        }
    }
}