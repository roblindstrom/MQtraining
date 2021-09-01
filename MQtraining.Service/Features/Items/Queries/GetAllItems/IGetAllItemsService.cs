using MQtraining.Shared.ResponseModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MQtraining.Services.Features.Items.Queries.GetAllItems
{
    public interface IGetAllItemsService
    {
        Task<List<ItemResponse>> GetAllItems();
    }
}
