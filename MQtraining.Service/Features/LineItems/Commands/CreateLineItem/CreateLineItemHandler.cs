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

        public CreateLineItemHandler(IMapper mapper, ILineItemRepository lineItemRepository, IItemRepository itemRepository)
        {
            _mapper = mapper;
            _lineItemRepository = lineItemRepository;
            _itemRepository = itemRepository;
            
        }

        public async Task<LineItemResponse> CreateLineItem(LineItemRequest lineItemRequest)
        {


            var lineitem = new LineItem()
            {
                ItemId = lineItemRequest.ItemId,
                OrderId = lineItemRequest.OrderId,
                Quantity = lineItemRequest.Quantity,
                Item = await _itemRepository.GetByIdAsync(lineItemRequest.ItemId)
            };

            await _lineItemRepository.AddAsync(lineitem);
            return _mapper.Map<LineItemResponse>(lineitem);


        }





    }
}
