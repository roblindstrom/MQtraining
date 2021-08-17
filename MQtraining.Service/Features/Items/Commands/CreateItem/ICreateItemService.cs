using MQtraining.Shared.RequestModels;
using MQtraining.Shared.ResponseModels;
using System.Threading.Tasks;

namespace MQtraining.Services.Features.Items.Commands.CreateItem
{
    public interface ICreateItemService
    {
        Task<ItemResponse> CreateItem(ItemRequest itemRequest);
    }
}
