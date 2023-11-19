using TemplateMethodPattern;

CoffeeMaker turkishCoffeeMaker = new TurkishCoffeeMaker();
turkishCoffeeMaker.PrepareDrink();

CoffeeMaker espressoMaker = new EspressoMaker();
espressoMaker.PrepareDrink();