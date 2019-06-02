using System;

namespace Factories.Problem 
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new PizzaStore();
            store.OrderPizza("cheese");
        }
    }
}
