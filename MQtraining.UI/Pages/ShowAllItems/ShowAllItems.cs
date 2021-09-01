using AutoMapper;
using Microsoft.AspNetCore.Components;
using MQtraining.Shared.Models;
using MQtraining.Shared.RequestModels;
using MQtraining.Shared.ResponseModels;
using MQtraining.UI.Services.Items;
using MQtraining.UI.Services.LineItems;
using MQtraining.UI.Services.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MQtraining.UI.Pages.ShowAllItems
{
    public partial class ShowAllItems : ComponentBase
    {
        public ICollection<ItemResponse> Items { get; set; }
        public ICollection<LineItemRequest> LineItems { get; set; }

        public LineItemRequest LineItem { get; set; }

        public ItemRequest Item { get; set; }

        public OrderRequest Order { get; set; } = new OrderRequest() {  };

        private readonly Guid empty;

        [Inject]
        public IItemDataService ItemDataService { get; set; }
        [Inject]
        public ILineItemDataService LineItemDataService { get; set; }

        [Inject]
        public IOrderDataService OrderDataService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IMapper Mapper { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Items = await ItemDataService.GetAllItems();

            if (Order.OrderId == empty)
            {
                OrderRequest order = new OrderRequest 
                {
                    OrderId = Guid.NewGuid()
                };
                
                Order = order;

            }
        }

        public async Task AddLineItemToOrder(Guid itemId)
        {

            var itemResponse = await ItemDataService.GetItemById(itemId);

            var itemRequest = Mapper.Map<ItemRequest>(itemResponse);

            LineItemRequest lineitem = new LineItemRequest { Item = itemRequest, ItemId = itemId};

            lineitem.Item = itemRequest;

            Order.LineItems.Add(lineitem);

        }

        public async Task CreateOrder(OrderRequest orderRequest)
        {
            orderRequest.Password = Guid.NewGuid();
             await OrderDataService.CreateOrder(orderRequest);

            
        }


    }
}
