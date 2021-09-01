using Microsoft.AspNetCore.Components;
using MQtraining.Shared.ResponseModels;
using MQtraining.UI.Services.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MQtraining.UI.Pages.ShowSpecificOrder
{
    public partial class ShowSpecificOrder
    {
        public OrderResponse OrderResponse { get; set; }

        [Inject]
        public IOrderDataService OrderDataService { get; set; }

        [Parameter]
        public Guid OrderId { get; set; }


        protected override async Task OnInitializedAsync()
        {
            OrderResponse = await OrderDataService.GetOrderById(OrderId);
        }
    }
}
