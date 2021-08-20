using Microsoft.AspNetCore.Mvc;
using MQtraining.Services.Features.Items.Commands.CreateItem;
using MQtraining.Services.Features.Items.Queries.GetAllItems;
using MQtraining.Services.Features.Items.Queries.GetItemById;
using MQtraining.Shared.RequestModels;
using MQtraining.Shared.ResponseModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MQtraining.API.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]


    public class ItemController : Controller
    {
        private readonly ICreateItemService _createItemService;
        private readonly IGetAllItemsService _getAllItemsService;
        private readonly IGetItemByIdService _getItemByIdService;


        public ItemController(ICreateItemService createItemService, IGetAllItemsService getAllItemsService, IGetItemByIdService getItemByIdService)
        {
            _createItemService = createItemService;
            _getAllItemsService = getAllItemsService;
            _getItemByIdService = getItemByIdService;
        }

        [HttpPost]
        public async Task<ItemResponse> CreateItem(ItemRequest itemRequest)
        {
            return await _createItemService.CreateItem(itemRequest);
        }

        [HttpGet]
        public async Task<List<ItemResponse>> GetAllItems() 
        {
            return await _getAllItemsService.GetAllItems();
        }

        [HttpGet("{itemId}")]
        public async Task<ItemResponse> GetItemById(Guid itemId)
        {
            return await _getItemByIdService.GetItemById(itemId);
        }

    }
}
