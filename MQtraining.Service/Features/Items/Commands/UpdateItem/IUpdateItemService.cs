using MQtraining.Shared.RequestModels;
using MQtraining.Shared.ResponseModels;
using System.Threading.Tasks;

namespace MQtraining.Services.Features.Items.Commands.UpdateItem
{
    public interface IUpdateItemService
    {
        Task<ItemResponse> UpdateItem(ItemRequest itemRequest);
    }
}
