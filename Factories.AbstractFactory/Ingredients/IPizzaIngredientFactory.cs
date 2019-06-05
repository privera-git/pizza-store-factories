using Factories.AbstractFactory.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factories.AbstractFactory.Ingredients
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();

        ISauce CreateSauce();

        ICheese CreateChesse();

        IVeggies[] CreateVeggies();

        IPepperoni CreatePepperoni();

        IClams CreateClam();
    }
}
