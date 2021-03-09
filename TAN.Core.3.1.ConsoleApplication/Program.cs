using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using TAN.Core._3._1.ConsoleApplication.ApplicationCore.Interfaces;

namespace TAN.Core._3._1.ConsoleApplication
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var serviceProvider = DependencyInject();

            var contactController = serviceProvider.GetService<IContactController>();
            await contactController.AddAsync();
        }

        private static ServiceProvider DependencyInject()
        {
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddDatabaseConfigure()
                .AddApplicationCoreClassDependencyInject()
                .BuildServiceProvider();

            return serviceProvider;
        }
    }
}