using DOOKKI_APP.Models.Entities;
using DOOKKI_APP.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOKKI_APP.Services
{
    internal class ServiceConfigurator
    {
        public static ServiceProvider ConfigureServices(ServiceCollection services, IConfiguration configuration)
        {
            // Register configuration so it can be injected
            services.AddSingleton<IConfiguration>(configuration);

            // Register ApplicationDbContext with the connection string from config
            services.AddDbContext<DookkiContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // Add other services here if needed
            services.AddTransient<MainForm>(); // Register MainForm for DI
            services.AddTransient<Views.Login>();
            services.AddTransient<Views.ManageProducts>();
            services.AddTransient<Views.TestForm>();
            services.AddTransient<Views.AccountManagement>();

            services.AddTransient<Views.ManageEployee>();
            services.AddTransient<Views.InputCustomer>();
            // Apply pending migrations at startup
            var serviceProvider = services.BuildServiceProvider();
            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<DookkiContext>();
                context.Database.Migrate(); // This applies pending migrations
            }
            return services.BuildServiceProvider();
        }
    }
}
