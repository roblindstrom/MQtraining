using MQtraining.Shared.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQtraining.Services.Features.Orders.Queries.GetOrderById
{
    public interface IGetOrderByIdService
    {
        Task<OrderResponse> GetOrderById(Guid orderId);

    }
}
