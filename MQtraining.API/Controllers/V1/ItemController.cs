﻿using Microsoft.AspNetCore.Mvc;
using MQtraining.Services.Features.Items.Commands.CreateItem;
using MQtraining.Shared.CommandModels;
using MQtraining.Shared.ResponseModels;
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
        public async Task<ItemResponse> CreateItem(ItemCommand itemCommand)
        {
            return await _createItemService.CreateItem(itemCommand);
        }
    }
}
