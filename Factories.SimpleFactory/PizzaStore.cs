﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Factories.SimpleFactory
{
    public class PizzaStore
    {
        private SimplePizzaFactory _factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            _factory = factory;
        }
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = _factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
