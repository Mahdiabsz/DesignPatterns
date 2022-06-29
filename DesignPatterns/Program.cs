using DesignPatterns;
using DesignPatterns.Builder;
using DesignPatterns.Decorator;
using DesignPatterns.Observer;
using DesignPatterns.Strategy;

Console.WriteLine("please select one of patterns from below : ");
Console.WriteLine("1) Decorator pattern \n" +
    "2) Singleton pattern \n" +
    "3) Strategy pattern \n" +
    "4) Builder pattern \n" +
    "5) Observer pattern \n");

int patternNumber = Convert.ToInt32(Console.ReadLine());

switch (patternNumber)
{
    case 1:
        DecoratorPattern();
        break;
    case 2:
        SingletonPattern();
        break;
    case 3:
        StrategyPattern();
        break;
    case 4:
        BuilderPattern();
        break;
    case 5:
        ObserverPattern();
        break;
}

#region Decorator pattern
void DecoratorPattern()
{
    IPizza pizza = new Pizza();
    IPizza cheesePizza = new CheeseDecorator(pizza);
    IPizza onionPizza = new OnionDecorator(cheesePizza);
    IPizza tomatoPizza = new TomatoDecorator(onionPizza);
    Console.WriteLine(tomatoPizza.GetPizza());
    Console.ReadLine();
}
#endregion

#region Singleton pattern
void SingletonPattern()
{
    Singleton singleton = Singleton.Instance;
    Console.WriteLine(singleton.PrintText());
    Console.ReadLine();
}
#endregion

#region Strategy pattern
void StrategyPattern()
{
    WebApplication webApplication = new WebApplication(BrowserType.IE);
    webApplication.SendAsyncRequestToServer("https://www.google.com");
    Console.ReadLine();
}
#endregion

#region Builder pattern
void BuilderPattern()
{
    var userBuilder = new UserBuilder();
    User user = userBuilder
        .WithName("mahdi")
        .WithFamily("abbaszadeh")
        .WithPhone("12345678910")
        .WithEmail("mahdi@gmail.com")
        .WithAddress("test address");
    Console.WriteLine("Name: {0}, Family: {1}, Phone: {2}, Email: {3}, Address: {4}",
        user.Name, user.Family, user.Phone, user.Email, user.Address);
    Console.ReadLine();
}
#endregion

#region Observer pattern
void ObserverPattern()
{
    WeatherStation weatherStation = new WeatherStation();

    NewsAgency agency1 = new NewsAgency("First agency News");
    weatherStation.Attach(agency1);

    NewsAgency agency2 = new NewsAgency("Second agency News");
    weatherStation.Attach(agency2);

    weatherStation.Temperature = 24.3f;
    weatherStation.Temperature = 17.9f;
    weatherStation.Temperature = 29.6f;
    weatherStation.Temperature = 14.3f;

    Console.ReadLine();
}
#endregion