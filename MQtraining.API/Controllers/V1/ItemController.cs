using Microsoft.AspNetCore.Mvc;
using MQtraining.Services.Features.Items.Commands.CreateItem;
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


    public class ItemController : Controller
    {
        public readonly ICreateItemService _createItemService;

        public ItemController(ICreateItemService createItemService)
        {
            _createItemService = createItemService;
        }

        [HttpPost]
        public async Task<ItemResponse> CreateItem(ViewItem viewItem) 
        {
            return await _createItemService.CreateItem(viewItem);
        }
    }
}
