using System;
using System.Collections.Generic;
using System.Text;
using Factories.AbstractFactory.Ingredients;

namespace Factories.AbstractFactory.Chicago
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateChesse()
        {
            return new ReggianoCheese();
        }

        public IClams CreateClam()
        {
            return new FreshClams();
        }

        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public IVeggies[] CreateVeggies()
        {
            return new IVeggies[] { new BlackOlives(), new Spinach(), new Eggplant() };
        }
    }
}
