using AutoMapper;
using MQtraining.Shared.CommandModels;
using MQtraining.Shared.DTOModels;
using MQtraining.Shared.IRepository;
using MQtraining.Shared.Models;
using MQtraining.Shared.ResponseModels;
using System;
using System.Collections.Generic;
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


        public async Task<OrderResponse> CreateOrder(OrderCommand orderCommand)
        {

            var order = new Order()
            {
                OrderId = new Guid(),
                Password = new Guid(),
                LineItems = _mapper.Map<IEnumerable<LineItem>>(orderCommand.LineItems)
            };

            await _orderRepository.AddAsync(order);
            var orderResponse = _mapper.Map<OrderResponse>(order);
            orderResponse.Items = _mapper.Map<IEnumerable<DTOLineItem>>(order.LineItems);



            return orderResponse;

        }
    }
}
