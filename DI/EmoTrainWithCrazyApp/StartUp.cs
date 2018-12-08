using System;
using EmoTrainWithCrazyApp.Core;
using EmoTrainWithCrazyApp.Models;
using EmoTrainWithCrazyApp.Models.Contracts;
using EmoTrainWithCrazyApp.Modules;
using Microsoft.Extensions.DependencyInjection;
using SoftUniDi;

namespace EmoTrainWithCrazyApp
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //var injector = DependencyInjector.CreateInjector(new Module());
            //var engine = injector.Inject<Engine>();
            //engine.Run();

            IServiceProvider serviceProvider = ConfigureServices();
            var engine = serviceProvider.GetService<IEngine>();
            engine.Run();
        }

        private static IServiceProvider ConfigureServices()
        {
            IServiceCollection serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<IEngine, Engine>();
            serviceCollection.AddTransient<IWrite, ConsoleWriter>();
            serviceCollection.AddTransient<IWrite, FileWriter>();
            serviceCollection.AddTransient<IRead, ConsoleReader>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            return serviceProvider;
        }
    }
}
