using AutoMapper;
using MQtraining.Shared.IRepository;
using MQtraining.Shared.Models;
using MQtraining.Shared.RequestModels;
using MQtraining.Shared.ResponseModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MQtraining.Services.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderHandler : ICreateOrderService
    {

        private readonly IOrderRepository _orderRepository;
        private readonly ILineItemRepository _lineItemRepository;
        private readonly IItemRepository _itemRepository;
        private readonly IMapper _mapper;

        public CreateOrderHandler(IMapper mapper, IOrderRepository orderRepository, ILineItemRepository lineItemRepository, IItemRepository itemRepository)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
            _lineItemRepository = lineItemRepository;
            _itemRepository = itemRepository;
        }


        public async Task<OrderResponse> CreateOrder(OrderRequest orderRequest)
        {
            var lineItemList = new List<LineItem>();

            Order order = new Order
            {
                OrderId = orderRequest.OrderId,
                Password = orderRequest.Password,
                LineItems = new List<LineItem>()

            };

            await _orderRepository.AddAsync(order);

            foreach (var lineitemRequest in orderRequest.LineItems)
            {
                var lineitem = _mapper.Map<LineItem>(lineitemRequest);
                lineitem.OrderId = order.OrderId;
                lineitem.ItemId = lineitemRequest.ItemId;
                lineitem.Item = await _itemRepository.GetByIdAsync(lineitemRequest.ItemId);
                await _lineItemRepository.AddAsync(lineitem);
                lineItemList.Add(lineitem);
            };
            order.LineItems = lineItemList;

            await _orderRepository.UpdateAsync(order);

            return _mapper.Map<OrderResponse>(order);

        }
    }
}
