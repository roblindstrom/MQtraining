using Microsoft.AspNetCore.Components;
using MQtraining.Shared.RequestModels;
using MQtraining.Shared.ResponseModels;
using MQtraining.UI.Services.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MQtraining.UI.Pages.ShowSpecificItem
{
    public partial class ShowSpecificItem
    {
        public ItemResponse ItemResponse { get; set; }
        [Inject]
        public IItemDataService ItemDataService { get; set; }
        [Parameter]
        public Guid ItemId { get; set; }


        protected override async Task OnInitializedAsync()
        {
            ItemResponse = await ItemDataService.GetItemDetails(ItemId);
        }


    }
}
