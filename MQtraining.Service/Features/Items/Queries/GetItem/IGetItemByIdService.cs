using MQtraining.Shared.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQtraining.Services.Features.Items.Queries.GetItem
{
    public interface IGetItemByIdService
    {
        Task<ItemResponse> GetItemById(Guid itemId);
    }
}
