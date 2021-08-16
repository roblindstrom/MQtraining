using Microsoft.AspNetCore.Components;
using MQtraining.Services.ResponseModels;
using MQtraining.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MQtraining.UI.Pages
{
    public partial class ShowAllOrders
    {
        public IEnumerable<OrderResponse> Orders { get; set; }

        [Inject]
        public IOrderDataService OrderDataService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Orders = await OrderDataService.GetAllOrders();
        }
    }
}
