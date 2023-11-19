using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public abstract class CoffeeMaker
    {
        public void PrepareDrink()
        {
            BoilWater();
            BrewCoffeeGrounds();
            PourInCup();
            AddCondiments();
        }

        protected void BoilWater()
        {
            Console.WriteLine("Su kaynatılıyor");
        }

        protected void PourInCup()
        {
            Console.WriteLine("Fincana dökülüyor");
        }

        protected abstract void BrewCoffeeGrounds();
        protected abstract void AddCondiments();
    }
}
