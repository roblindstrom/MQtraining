using MQtraining.Shared.CommandModels;
using MQtraining.Shared.ResponseModels;
using System.Threading.Tasks;

namespace MQtraining.Services.Features.LineItems.Commands.CreateLineItem
{
    public interface ICreateLineItemService
    {
        Task<LineItemResponse> CreateLineItem(LineItemCommand lineItemCommand);
    }
}
