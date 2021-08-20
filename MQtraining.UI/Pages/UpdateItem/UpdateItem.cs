using Microsoft.AspNetCore.Components;
using MQtraining.Shared.RequestModels;
using MQtraining.Shared.ResponseModels;
using MQtraining.UI.Services.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MQtraining.UI.Pages.UpdateItem
{
    public partial class UpdateItem : ComponentBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public IItemDataService ItemDataService { get; set; }
        [Parameter]
        public Guid ItemId { get; set; }
        
        public ItemRequest ItemRequest { get; set; } = new ItemRequest { };

        protected async Task EditItem(ItemRequest itemRequest) 
        {

            await ItemDataService.UpdateItem(itemRequest);
        }


        protected override async Task OnInitializedAsync()
        {
            ItemRequest = await ItemDataService.GetItemDetails(ItemId);
        }

        protected async Task HandleValidSubmit()
        {
            await ItemDataService.UpdateItem(ItemRequest);

            NavigationManager.NavigateTo("items");
        }

       


    }
}
