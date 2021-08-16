using AutoMapper;
using MQtraining.Shared.DTOModels;
using MQtraining.Shared.IRepository;
using MQtraining.Shared.ResponseModels;
using System.Collections.Generic;
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
