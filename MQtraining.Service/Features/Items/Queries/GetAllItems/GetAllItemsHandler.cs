using AutoMapper;
using MQtraining.Shared.IRepository;
using MQtraining.Shared.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQtraining.Services.Features.Items.Queries.GetAllItems
{
    public class GetAllItemsHandler : IGetAllItemsService
    {
        private readonly IItemRepository _itemRepository;
        private readonly IMapper _mapper;

        public GetAllItemsHandler(IMapper mapper, IItemRepository itemRepository)
        {
            _mapper = mapper;
            _itemRepository = itemRepository;
        }

        public async Task<List<ItemResponse>> GetAllItems()
        {
            var items = await _itemRepository.ListAllAsync();
            var itemResponse =_mapper.Map<List<ItemResponse>>(items);


            return itemResponse;
        }
    }
}
