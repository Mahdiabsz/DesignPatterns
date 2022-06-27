using DesignPatterns.Decorator;

IPizza pizza = new Pizza();
IPizza cheesePizza = new CheeseDecorator(pizza);
IPizza onionPizza = new OnionDecorator(cheesePizza);
IPizza tomatoPizza = new TomatoDecorator(onionPizza);
Console.WriteLine(tomatoPizza.GetPizza());
Console.ReadLine();