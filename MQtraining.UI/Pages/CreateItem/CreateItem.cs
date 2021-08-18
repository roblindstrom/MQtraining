using Microsoft.AspNetCore.Components;
using MQtraining.Shared.Models;
using MQtraining.Shared.RequestModels;
using MQtraining.UI.Services.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MQtraining.UI.Pages.CreateItem
{
    public partial class CreateItem
    {
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;

        public ItemRequest ItemRequest { get; set; } =
            new ItemRequest {  };

        [Inject]
        public IItemDataService ItemDataService { get; set; }
        protected async Task HandleValidSubmit()
        {
                await ItemDataService.CreateItem(ItemRequest);
                StateHasChanged();
        }

       
    }
}
