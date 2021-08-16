using MQtraining.Services.ResponseModels;
using MQtraining.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MQtraining.UI.Services
{
    public interface IOrderDataService
    {
        Task<IEnumerable<OrderResponse>> GetAllOrders();

    }
}
