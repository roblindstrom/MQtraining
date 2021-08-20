using AutoMapper;
using MQtraining.Shared.DTOModels;
using MQtraining.Shared.IRepository;
using MQtraining.Shared.Models;
using MQtraining.Shared.RequestModels;
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


        public async Task<OrderResponse> CreateOrder(OrderRequest orderRequest)
        {

            var order = new Order()
            {
                OrderId = Guid.NewGuid(),
                Password = Guid.NewGuid(),
                LineItems = _mapper.Map<List<LineItem>>(orderRequest.LineItems)
            };



            await _orderRepository.AddAsync(order);
            var orderResponse = _mapper.Map<OrderResponse>(order);
            orderResponse.LineItems = _mapper.Map<List<LineItemResponse>>(order.LineItems);

            


            return orderResponse;

        }
    }
}
