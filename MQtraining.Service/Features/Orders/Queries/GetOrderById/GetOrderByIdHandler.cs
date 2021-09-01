using AutoMapper;
using MQtraining.Shared.DTOModels;
using MQtraining.Shared.IRepository;
using MQtraining.Shared.Models;
using MQtraining.Shared.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQtraining.Services.Features.Orders.Queries.GetOrderById
{
    public class GetOrderByIdHandler : IGetOrderByIdService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public GetOrderByIdHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public Task<OrderResponse> GetOrderById(Guid orderId)
        {
            var order =  _orderRepository.GetOrderById(orderId);
            var orderResponse = _mapper.Map<OrderResponse>(order);
            return orderResponse;
        }
    }
}
