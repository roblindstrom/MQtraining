using Microsoft.AspNetCore.Mvc;
using MQtraining.Services.Features.LineItems.Commands.CreateLineItem;
using MQtraining.Shared.CommandModels;
using MQtraining.Shared.ResponseModels;
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
        public async Task<LineItemResponse> CreateLineItem(LineItemCommand lineItemCommand)
        {
            return await _createLineItemService.CreateLineItem(lineItemCommand);
        }
    }
}
