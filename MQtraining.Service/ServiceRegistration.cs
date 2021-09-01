using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MQtraining.Data;
using MQtraining.Data.Repositories;
using MQtraining.Services.Features.Items.Commands.CreateItem;
using MQtraining.Services.Features.Items.Commands.DeleteItem;
using MQtraining.Services.Features.Items.Commands.UpdateItem;
using MQtraining.Services.Features.Items.Queries.GetAllItems;
using MQtraining.Services.Features.Items.Queries.GetItemById;
using MQtraining.Services.Features.LineItems.Commands.CreateLineItem;
using MQtraining.Services.Features.Orders.Commands.CreateOrder;
using MQtraining.Services.Features.Orders.Queries.GetAllOrders;
using MQtraining.Services.Features.Orders.Queries.GetOrderById;
using MQtraining.Shared.IRepository;
using System.Reflection;

namespace MQtraining.Services
{
    public static class ServiceRegistration
    {

        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            //Order services
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<ICreateOrderService, CreateOrderHandler>();
            services.AddScoped<IGetAllOrdersService, GetAllOrdersHandler>();
            services.AddScoped<IGetOrderByIdService, GetOrderByIdHandler>();

            //Item services
            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped<ICreateItemService, CreateItemHandler>();
            services.AddScoped<IGetAllItemsService, GetAllItemsHandler>();
            services.AddScoped<IDeleteItemService, DeleteItemHandler>();
            services.AddScoped<IUpdateItemService, UpdateItemHandler>();
            services.AddScoped<IGetItemByIdService, GetItemByIdHandler>();

            //LineItem services
            services.AddScoped<ILineItemRepository, LineItemRepository>();
            services.AddScoped<ICreateLineItemService, CreateLineItemHandler>();


            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddDataServices(configuration);

            return services;
        }

    }
}
