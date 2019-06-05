using Factories.AbstractFactory.Ingredients;
using System;
using System.Collections.Generic;

namespace Factories.AbstractFactory
{ 
    internal class VeggiePizza : Pizza
    {
        public VeggiePizza(IPizzaIngredientFactory ingredientFactory) : base(ingredientFactory) { }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateChesse();
            Veggies = _ingredientFactory.CreateVeggies();
        }
    }
}