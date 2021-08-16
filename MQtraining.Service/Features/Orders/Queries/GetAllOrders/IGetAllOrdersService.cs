using MQtraining.Services.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQtraining.Services.Features.Orders.Queries.GetAllOrders
{
    public interface IGetAllOrdersService
    {
        Task<List<OrderResponse>> GetAllOrders();
    }
}
