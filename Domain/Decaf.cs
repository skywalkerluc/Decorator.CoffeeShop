using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.CoffeeShop.Domain
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Descafeinado";
        }

        public override double cost()
        {
            return 1.05;
        }
    }
}
