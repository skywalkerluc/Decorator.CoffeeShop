using Decorator.CoffeeShop.Decorators;
using Decorator.CoffeeShop.Domain;
using System;

namespace Decorator.CoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage bev = new Espresso();
            Console.WriteLine(bev.GetDescription() + "- $" + bev.cost());

            Beverage bev2 = new DarkRoast();
            bev2 = new Soy(bev2);
            bev2 = new Mocha(bev2);
            bev2 = new Soy(bev2);
            Console.WriteLine(bev2.GetDescription() + " - $" + bev2.cost());

            Beverage bev3 = new HouseBlend();
            bev3 = new Soy(bev3);
            bev3 = new Mocha(bev3);
            bev3 = new Whip(bev3);
            bev3 = new Soy(bev3);
            bev3 = new Whip(bev3);
            Console.WriteLine(bev3.GetDescription() + " - $" + bev3.cost());
            Console.ReadKey();
        }
    }
}
