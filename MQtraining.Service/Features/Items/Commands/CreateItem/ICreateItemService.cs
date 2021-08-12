using MQtraining.Services.ResponseModels;
using MQtraining.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQtraining.Services.Features.Items.Commands.CreateItem
{
    public interface ICreateItemService
    {
        Task<ItemResponse> CreateItem(ViewItem viewItem);
    }
}
