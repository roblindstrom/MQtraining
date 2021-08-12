using Microsoft.AspNetCore.Mvc;
using MQtraining.Services.Features.Orders.Commands.CreateOrder;
using MQtraining.Services.ResponseModels;
using MQtraining.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MQtraining.API.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        public readonly ICreateOrderService _createOrderService;
        public OrderController(ICreateOrderService createOrderService)
        {
            _createOrderService = createOrderService;
        }

        [HttpPost("")]
        public async Task<OrderResponse> CreateOrder(ViewOrder orderview)
        {
            return await _createOrderService.CreateOrder(orderview);
        }

    }
}
