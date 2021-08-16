using AutoMapper;
using MQtraining.Services.DTOModels;
using MQtraining.Services.ResponseModels;
using MQtraining.Shared.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQtraining.Services.Features.Orders.Queries.GetAllOrders
{
    public class GetAllOrdersHandler : IGetAllOrdersService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public GetAllOrdersHandler(IMapper mapper, IOrderRepository orderRepository)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
        }

        public async Task<List<OrderResponse>> GetAllOrders() 
        {
            var orders = await _orderRepository.ListAllAsync();
            var orderResponses = new List<OrderResponse>();

            foreach (var order in orders)
            {
                var orderResponse = _mapper.Map<OrderResponse>(order);
                orderResponse.Items = _mapper.Map<List<DTOLineItem>>(order.LineItems);
                orderResponses.Add(orderResponse);
            }
            

            return orderResponses;
        }

    }
}
