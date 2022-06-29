using DesignPatterns;
using DesignPatterns.Builder;
using DesignPatterns.Decorator;
using DesignPatterns.Strategy;

#region Decorator pattern
IPizza pizza = new Pizza();
IPizza cheesePizza = new CheeseDecorator(pizza);
IPizza onionPizza = new OnionDecorator(cheesePizza);
IPizza tomatoPizza = new TomatoDecorator(onionPizza);
Console.WriteLine(tomatoPizza.GetPizza());
Console.Write("this was decorator pattern. Press enter to process singleton pattern : ");
Console.ReadLine();
#endregion

#region Singleton pattern
Singleton singleton = Singleton.Instance;
Console.WriteLine(singleton.PrintText());
Console.Write("this was singleton pattern. Press enter to process strategy pattern : ");
Console.ReadLine();
#endregion

#region Strategy pattern
WebApplication webApplication = new WebApplication(BrowserType.IE);
webApplication.SendAsyncRequestToServer("https://www.google.com");
Console.Write("this was strategy pattern. Press enter to process builder pattern : ");
Console.ReadLine();
#endregion

#region Builder pattern
var userBuilder = new UserBuilder();
User user = userBuilder
    .WithName("mahdi")
    .WithFamily("abbaszadeh")
    .WithPhone("12345678910")
    .WithEmail("mahdi@gmail.com")
    .WithAddress("test address");
Console.WriteLine("Name: {0}, Family: {1}, Phone: {2}, Email: {3}, Address: {4}",
    user.Name, user.Family, user.Phone, user.Email, user.Address);
Console.Write("this was builder pattern. Press enter to process builder pattern : ");
Console.ReadLine();
#endregion