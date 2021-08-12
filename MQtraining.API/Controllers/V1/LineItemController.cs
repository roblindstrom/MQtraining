using Microsoft.AspNetCore.Mvc;
using MQtraining.Services.Features.LineItems.Commands.CreateLineItem;
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
    public class LineItemController : Controller
    {
        private readonly ICreateLineItemService _createLineItemService;

        public LineItemController(ICreateLineItemService createLineItemService)
        {
            _createLineItemService = createLineItemService;
        }

        [HttpPost]
        public async Task<LineItemResponse> CreateLineItem(ViewLineItem viewLineItem) 
        {
            return await _createLineItemService.CreateLineItem(viewLineItem);
        }
    }
}
