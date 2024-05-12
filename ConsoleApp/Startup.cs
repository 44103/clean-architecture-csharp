using ConsoleApp.User;
using ConsoleApp.User.Create;
using Domain.Application.User;
using Domain.Domain.Users;
using Infrastructure.InMemoryInfrastructure.Users;
using Microsoft.Extensions.DependencyInjection;
using UseCase.User.Create;

namespace ConsoleApp
{
    public static class Startup
    {
        public static IServiceCollection ServiceCollection { get; } = new ServiceCollection();

        public static void Run()
        {
            setupDebug();
        }

        private static void setupDebug()
        {
            ServiceCollection.AddTransient<IUserRepository, InMemoryUserRepository>();
            ServiceCollection.AddTransient<IUserCreatePresenter, UserCreatePresenter>();
            ServiceCollection.AddTransient<IUserCreateUseCase, UserCreateInteractor>();
            ServiceCollection.AddTransient<UserController>();
        }
    }
}
