using DesignPatterns;
using DesignPatterns.Decorator;

#region Decorator pattern
IPizza pizza = new Pizza();
IPizza cheesePizza = new CheeseDecorator(pizza);
IPizza onionPizza = new OnionDecorator(cheesePizza);
IPizza tomatoPizza = new TomatoDecorator(onionPizza);
Console.WriteLine(tomatoPizza.GetPizza());
Console.Write("Press enter to process singleton pattern : ");
Console.ReadLine();
#endregion

#region Singleton pattern
Singleton singleton = Singleton.Instance;
Console.WriteLine(singleton.PrintText());
Console.Write("Press enter to process singleton pattern : ");
Console.ReadLine();
#endregion