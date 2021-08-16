using MQtraining.Shared.ResponseModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MQtraining.Services.Features.Orders.Queries.GetAllOrders
{
    public interface IGetAllOrdersService
    {
        Task<List<OrderResponse>> GetAllOrders();
    }
}
