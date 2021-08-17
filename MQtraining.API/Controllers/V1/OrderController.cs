using Microsoft.AspNetCore.Mvc;
using MQtraining.Services.Features.Orders.Commands.CreateOrder;
using MQtraining.Services.Features.Orders.Queries.GetAllOrders;
using MQtraining.Shared.RequestModels;
using MQtraining.Shared.ResponseModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MQtraining.API.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly ICreateOrderService _createOrderService;
        private readonly IGetAllOrdersService _getAllOrdersService;
        public OrderController(ICreateOrderService createOrderService, IGetAllOrdersService getAllOrdersService)
        {
            _createOrderService = createOrderService;
            _getAllOrdersService = getAllOrdersService;
        }

        [HttpPost("")]
        public async Task<OrderResponse> CreateOrder(OrderRequest orderRequest)
        {
            return await _createOrderService.CreateOrder(orderRequest);
        }

        [HttpGet("")]
        public async Task<List<OrderResponse>> GetAllOrders()
        {
            return await _getAllOrdersService.GetAllOrders();
        }


    }
}
