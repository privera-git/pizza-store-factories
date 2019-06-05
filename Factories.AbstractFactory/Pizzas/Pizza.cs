using Factories.AbstractFactory.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factories.AbstractFactory
{
    public abstract class Pizza
    {
        protected IPizzaIngredientFactory _ingredientFactory;

        public string Name { get; set; }

        public IDough Dough { get; set; }

        public ISauce Sauce { get; set; }

        public IVeggies[] Veggies { get; set; }

        public ICheese Cheese { get; set; }

        public IPepperoni Pepperoni { get; set; }

        public IClams Clam { get; set; }

        public Pizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public abstract void Prepare();

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }
}
