using System;

namespace Factories.SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new PizzaStore(
                new SimplePizzaFactory()
            );

            store.OrderPizza("cheese");
        }
    }
}
