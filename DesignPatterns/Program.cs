using DesignPatterns;
using DesignPatterns.Decorator;
using DesignPatterns.Strategy;

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
Console.Write("Press enter to process strategy pattern : ");
Console.ReadLine();
#endregion

#region Strategy pattern
WebApplication webApplication = new WebApplication(BrowserType.IE);
webApplication.SendAsyncRequestToServer("https://www.google.com");
Console.Write("Press enter to process builder pattern : ");
Console.ReadLine();
#endregion