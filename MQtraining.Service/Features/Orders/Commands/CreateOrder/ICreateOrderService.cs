using MQtraining.Shared.CommandModels;
using MQtraining.Shared.ResponseModels;
using System.Threading.Tasks;

namespace MQtraining.Services.Features.Orders.Commands.CreateOrder
{
    public interface ICreateOrderService
    {
        Task<OrderResponse> CreateOrder(OrderCommand orderCommand);
    }
}
