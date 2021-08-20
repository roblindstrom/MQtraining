using MQtraining.Shared.RequestModels;
using MQtraining.Shared.ResponseModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MQtraining.UI.Services.Orders
{
    public interface IOrderDataService
    {
        Task<ICollection<OrderResponse>> GetAllOrders();
        Task<OrderResponse> CreateOrder(OrderRequest orderRequest);

    }
}
