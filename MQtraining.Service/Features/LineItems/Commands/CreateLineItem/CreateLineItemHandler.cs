using AutoMapper;
using MQtraining.Shared.CommandModels;
using MQtraining.Shared.IRepository;
using MQtraining.Shared.Models;
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

        public async Task<LineItemResponse> CreateLineItem(LineItemCommand lineItemCommand)
        {


            var lineitem = new LineItem()
            {
                LineItemId = new Guid(),
                Quantity = lineItemCommand.Quantity,
                Item = await _itemRepository.GetByIdAsync(lineItemCommand.Item.ItemId),
                Order = await _orderRepository.GetByIdAsync(lineItemCommand.Order.OrderId)
            };

            await _lineItemRepository.AddAsync(lineitem);
            return _mapper.Map<LineItemResponse>(lineitem);


        }





    }
}
