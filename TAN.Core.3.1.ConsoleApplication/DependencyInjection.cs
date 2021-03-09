using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using TAN.Core._3._1.ConsoleApplication.ApplicationCore.Facades;
using TAN.Core._3._1.ConsoleApplication.ApplicationCore.Interfaces;
using TAN.Core._3._1.ConsoleApplication.ApplicationCore.Services;
using TAN.Core._3._1.ConsoleApplication.Controller;
using TAN.Core._3._1.ConsoleApplication.Infrastructure.Data;

namespace TAN.Core._3._1.ConsoleApplication
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDatabaseConfigure(this IServiceCollection services)
        {
            var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
            services.AddEntityFrameworkNpgsql().AddDbContext<CatalogContext>(c => c.UseNpgsql(connectionString));

            return services;
        }

        public static IServiceCollection AddApplicationCoreClassDependencyInject(this IServiceCollection services)
        {
            services.AddScoped<IContactController, ContactController>();

            services.AddScoped<IContactFacade, ContactFacade>();

            services.AddTransient<IContactService>(s => new ContactService("teste"));

            return services;
        }
    }
}