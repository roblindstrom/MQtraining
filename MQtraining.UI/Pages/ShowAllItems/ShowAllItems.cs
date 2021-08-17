using Microsoft.AspNetCore.Components;
using MQtraining.Shared.ResponseModels;
using MQtraining.UI.Services.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MQtraining.UI.Pages.ShowAllItems
{
    public partial class ShowAllItems
    {
        public IEnumerable<ItemResponse> Items { get; set; }

        [Inject]
        public IItemDataService ItemDataService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Items = await ItemDataService.GetAllItems();
        }
    }
}
