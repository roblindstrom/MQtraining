using MQtraining.Shared.ResponseModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MQtraining.UI.Services
{
    public interface IOrderDataService
    {
        Task<IEnumerable<OrderResponse>> GetAllOrders();

    }
}
