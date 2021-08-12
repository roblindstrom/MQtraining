using MQtraining.Services.ResponseModels;
using MQtraining.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQtraining.Services.Features.LineItems.Commands.CreateLineItem
{
    public interface ICreateLineItemService
    {
        Task<LineItemResponse> CreateLineItem(ViewLineItem viewLineItem);
    }
}
