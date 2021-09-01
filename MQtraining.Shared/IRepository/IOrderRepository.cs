using MQtraining.Shared.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MQtraining.Shared.IRepository
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {
        Task<Order> GetOrderById(Guid OrderId);
    }
}
