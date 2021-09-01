using System;
using System.Threading.Tasks;

namespace MQtraining.Services.Features.Items.Commands.DeleteItem
{
    public interface IDeleteItemService
    {
        Task<Guid> DeleteItem(Guid itemId);
    }
}
