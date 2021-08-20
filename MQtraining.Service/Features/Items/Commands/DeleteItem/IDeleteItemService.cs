using MQtraining.Shared.RequestModels;
using MQtraining.Shared.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQtraining.Services.Features.Items.Commands.DeleteItem
{
    public interface IDeleteItemService
    {
        Task<Guid> DeleteItem(Guid itemId);
    }
}
