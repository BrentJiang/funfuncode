using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using QRCodeMain.Models;

namespace QRCodeMain
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Seed().Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
    /// <summary>
    /// A factory to create an instance of the StudentsContext 
    /// </summary>
    public static class MvcQrCodeContextFactory
    {
        public static MvcQrCodeContext Create(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MvcQrCodeContext>();
            optionsBuilder.UseSqlite(connectionString);

            // Ensure that the SQLite database and sechema is created!
            var context = new MvcQrCodeContext(optionsBuilder.Options);
            context.Database.EnsureCreated();

            return context;
        }
    }

    public static class DatabaseSeedInitializer
    {
        public static MvcQrCodeContext GetContext()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            // Get the connection string
            string connectionString = configuration.GetConnectionString("BookContext");
            return MvcQrCodeContextFactory.Create(connectionString);
        }

        public static IWebHost Seed(this IWebHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;

                try
                {
                    Task.Run(async () =>
                    {
                        var dataseed = new DataInitializer(GetContext());
                        await dataseed.InitializeDataAsync(serviceProvider);
                    }).Wait();

                }
                catch (Exception ex)
                {
                    var logger = serviceProvider.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                }
            }
            return host;
        }
    }
}
