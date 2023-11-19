using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
   public class TurkishCoffeeMaker : CoffeeMaker
    {
        protected override void BrewCoffeeGrounds()
        {
            Console.WriteLine("Türk kahvesi demleniyor");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Şeker ekleniyor");
        }
    }
}
