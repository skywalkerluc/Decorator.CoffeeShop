using Decorator.CoffeeShop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.CoffeeShop.Decorators
{
    public class Milk : CondimentDecorator
    {
        Beverage beverage;

        public Milk(Beverage _beverage)
        {
            this.beverage = _beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", " + this.GetType().Name.ToString();
        }

        public override double cost()
        {
            return .10 + beverage.cost();
        }
    }
}
