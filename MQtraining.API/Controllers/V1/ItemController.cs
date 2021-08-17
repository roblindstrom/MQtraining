using Microsoft.AspNetCore.Mvc;
using MQtraining.Services.Features.Items.Commands.CreateItem;
using MQtraining.Services.Features.Items.Queries.GetAllItems;
using MQtraining.Shared.RequestModels;
using MQtraining.Shared.ResponseModels;
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


        public ItemController(ICreateItemService createItemService, IGetAllItemsService getAllItemsService)
        {
            _createItemService = createItemService;
            _getAllItemsService = getAllItemsService;
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

    }
}
