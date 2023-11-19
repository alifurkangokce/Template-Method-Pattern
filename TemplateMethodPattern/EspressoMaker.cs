using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class EspressoMaker : CoffeeMaker
    {
        protected override void BrewCoffeeGrounds()
        {
            Console.WriteLine("Espresso demleniyor");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Süt ekleniyor");
        }
    }
}
