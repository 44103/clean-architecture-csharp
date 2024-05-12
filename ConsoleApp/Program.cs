using ConsoleApp;
using ConsoleApp.User;
using Microsoft.Extensions.DependencyInjection;

Startup.Run();
var serviceCollection = Startup.ServiceCollection;
var userCreateSubject = new UserCreateSubject();
serviceCollection.AddSingleton(userCreateSubject);
var serviceProvider = serviceCollection.BuildServiceProvider();
new ConsoleView(userCreateSubject);


Console.WriteLine("=============================");
Console.WriteLine("Welcome to Clean Architecture");
Console.WriteLine("=============================");
Console.WriteLine();
Console.WriteLine("Enter the name of the new user.");
Console.Write("User Name: ");
var userName = Console.ReadLine();
var controller = serviceProvider.GetService<UserController>();
controller.CreateUser(userName);

Console.WriteLine("Press any key to exit.");
Console.ReadKey();
