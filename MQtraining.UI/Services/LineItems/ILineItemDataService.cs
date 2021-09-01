using MQtraining.Shared.RequestModels;
using MQtraining.Shared.ResponseModels;
using System.Threading.Tasks;

namespace MQtraining.UI.Services.LineItems
{
    public interface ILineItemDataService
    {
        Task<LineItemResponse> CreateLineItem(LineItemRequest lineItemRequest);
    }
}
