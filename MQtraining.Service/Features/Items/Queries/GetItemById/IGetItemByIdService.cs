using MQtraining.Shared.ResponseModels;
using System;
using System.Threading.Tasks;

namespace MQtraining.Services.Features.Items.Queries.GetItemById
{
    public interface IGetItemByIdService
    {
        Task<ItemResponse> GetItemById(Guid itemId);
    }
}
