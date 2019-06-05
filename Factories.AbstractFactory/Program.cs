using Factories.AbstractFactory.Chicago;
using Factories.AbstractFactory.NewYork;
using System;

namespace Factories.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var nyStore = new NYStylePizzaStore();
            var chicagoStore = new ChicagoStylePizzaStore();

            Pizza pizza;
            
            pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.Name + Environment.NewLine);

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine("Joel ordered a " + pizza.Name + Environment.NewLine);
        }
    }
}
