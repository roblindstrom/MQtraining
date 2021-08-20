using Microsoft.AspNetCore.Components;
using MQtraining.Shared.RequestModels;
using MQtraining.Shared.ResponseModels;
using MQtraining.UI.Services.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MQtraining.UI.Pages.ShowAllItems
{
    public partial class ShowAllItems : ComponentBase
    {
        public IEnumerable<ItemResponse> Items { get; set; }

        [Inject]
        public IItemDataService ItemDataService { get; set; }

        public ItemRequest ItemRequest { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Items = await ItemDataService.GetAllItems();
        }

        protected async Task DeleteItem(Guid ItemId)
        {
            await ItemDataService.DeleteItem(ItemId);
            StateHasChanged();
        }
    }
}
