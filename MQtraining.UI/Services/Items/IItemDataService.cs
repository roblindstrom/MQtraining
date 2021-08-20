using MQtraining.Shared.RequestModels;
using MQtraining.Shared.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MQtraining.UI.Services.Items
{
    public interface IItemDataService
    {
        Task<ItemResponse> CreateItem(ItemRequest itemRequest);
        Task<ICollection<ItemResponse>> GetAllItems();

        Task<ItemResponse> GetItemById(Guid ItemId);
    }
}
