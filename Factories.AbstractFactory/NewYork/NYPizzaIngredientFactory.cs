using System;
using System.Collections.Generic;
using System.Text;
using Factories.AbstractFactory.Ingredients;

namespace Factories.AbstractFactory.NewYork
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateChesse()
        {
            return new MozzarellaCheese();
        }

        public IClams CreateClam()
        {
            return new FrozenClams();
        }

        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public IVeggies[] CreateVeggies()
        {
            return new IVeggies[] { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
        }
    }
}
