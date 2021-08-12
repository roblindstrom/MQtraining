using AutoMapper;
using MQtraining.Services.ResponseModels;
using MQtraining.Services.ViewModels;
using MQtraining.Shared.IRepository;
using MQtraining.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQtraining.Services.Features.LineItems.Commands.CreateLineItem
{
    class CreateLineItemHandler : ICreateLineItemService
    {
        private readonly IMapper _mapper;
        private readonly ILineItemRepository _lineItemRepository;
        private readonly IItemRepository _itemRepository;
        private readonly IOrderRepository _orderRepository;

        public CreateLineItemHandler(IMapper mapper, ILineItemRepository lineItemRepository, IItemRepository itemRepository, IOrderRepository orderRepository)
        {
            _mapper = mapper;
            _lineItemRepository = lineItemRepository;
            _itemRepository = itemRepository;
            _orderRepository = orderRepository;
        }

        public async Task<LineItemResponse> CreateLineItem(ViewLineItem viewLineItem) 
        {
            

            var lineitem = new LineItem()
            {
                LineItemId = new Guid(),
                Quantity = viewLineItem.Quantity,
                Item = await _itemRepository.GetByIdAsync(viewLineItem.Item.ItemId),
                Order = await _orderRepository.GetByIdAsync(viewLineItem.Order.OrderId)
        };

            await _lineItemRepository.AddAsync(lineitem);
            return _mapper.Map<LineItemResponse>(lineitem);


        }





    }
}
