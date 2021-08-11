using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MQtraining.Data;
using MQtraining.Data.Repositories;
using MQtraining.Shared.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQtraining.Services
{
    public static class ServiceRegistration
    {
        
            public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
            {
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IOrderRepository, OrderRepository>();

            services.AddDataServices(configuration);

                return services;
            }
       
    }
}
