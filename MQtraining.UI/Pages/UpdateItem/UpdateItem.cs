using AutoMapper;
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
        [Inject]
        public IMapper Mapper { get; set; }
        [Parameter]
        public Guid ItemId { get; set; }
        
        public ItemResponse ItemResponse { get; set; } = new ItemResponse { };

        //protected async Task EditItem(ItemRequest itemRequest) 
        //{

        //    await ItemDataService.UpdateItem(itemRequest);
        //}


        protected override async Task OnInitializedAsync()
        {
            ItemResponse = await ItemDataService.GetItemDetails(ItemId);
        }

        protected async Task HandleValidSubmit()
        {
            var itemRequest = Mapper.Map<ItemRequest>(ItemResponse);
            await ItemDataService.UpdateItem(itemRequest);

            NavigationManager.NavigateTo("items");
        }

       


    }
}
