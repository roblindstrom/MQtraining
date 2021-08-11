using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MQtraining.Data
{
    public static class DataServiceRegistration
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MQtrainingDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("MQtrainingConnectionString"),
                b => b.MigrationsAssembly(typeof(MQtrainingDbContext).Assembly.FullName)));

            return services;
        }
    }
}
