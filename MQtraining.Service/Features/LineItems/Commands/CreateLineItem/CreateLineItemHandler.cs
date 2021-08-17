using AutoMapper;
using MQtraining.Shared.IRepository;
using MQtraining.Shared.Models;
using MQtraining.Shared.RequestModels;
using MQtraining.Shared.ResponseModels;
using System;
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

        public async Task<LineItemResponse> CreateLineItem(LineItemRequest lineItemRequest)
        {


            var lineitem = new LineItem()
            {
                LineItemId = new Guid(),
                Quantity = lineItemRequest.Quantity,
                Item = await _itemRepository.GetByIdAsync(lineItemRequest.Item.ItemId),
                Order = await _orderRepository.GetByIdAsync(lineItemRequest.Order.OrderId)
            };

            await _lineItemRepository.AddAsync(lineitem);
            return _mapper.Map<LineItemResponse>(lineitem);


        }





    }
}
