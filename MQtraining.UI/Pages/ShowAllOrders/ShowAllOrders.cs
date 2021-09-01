using Microsoft.AspNetCore.Components;
using MQtraining.Shared.ResponseModels;
using MQtraining.UI.Services.Orders;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MQtraining.UI.Pages.ShowAllOrders
{
    public partial class ShowAllOrders : ComponentBase
    {
        public ICollection<OrderResponse> Orders { get; set; }

        [Inject]
        public IOrderDataService OrderDataService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Orders = await OrderDataService.GetAllOrders();
        }
    }
}
