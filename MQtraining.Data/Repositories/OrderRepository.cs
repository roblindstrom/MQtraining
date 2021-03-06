using Microsoft.EntityFrameworkCore;
using MQtraining.Shared.IRepository;
using MQtraining.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MQtraining.Data.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        protected new readonly MQtrainingDbContext _MQtrainingDbContext;
        public OrderRepository(MQtrainingDbContext mqtrainingDbContext) : base(mqtrainingDbContext)
        {
            _MQtrainingDbContext = mqtrainingDbContext;
        }

        public async Task<Order> GetOrderById(Guid OrderId) 
        {
            var order = await _MQtrainingDbContext.Orders
                .Include(o => o.LineItems)
                .ThenInclude(li => li.Item).FirstOrDefaultAsync(o => o.OrderId == OrderId);

            return order;
        }

    }
}
