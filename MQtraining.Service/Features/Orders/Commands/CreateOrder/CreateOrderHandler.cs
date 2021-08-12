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

namespace MQtraining.Services.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderHandler : ICreateOrderService
    {

        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public CreateOrderHandler(IMapper mapper, IOrderRepository orderRepository)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
        }


        public async Task<OrderResponse> CreateOrder(ViewOrder viewOrder)
        {
            
            var order = new Order()
            {
                OrderId = new Guid(),
                Password = new Guid(),
                Items = _mapper.Map<IEnumerable<Item>>(viewOrder.Items)
            };

                await _orderRepository.AddAsync(order);
            var orderResponse = _mapper.Map<OrderResponse>(order);
            orderResponse.Items = _mapper.Map<IEnumerable<ItemResponse>>(order.Items);



            return orderResponse;

        }
    }
}
