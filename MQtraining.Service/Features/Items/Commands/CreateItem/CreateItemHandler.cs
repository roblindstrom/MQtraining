using AutoMapper;
using MQtraining.Shared.IRepository;
using MQtraining.Shared.Models;
using MQtraining.Shared.RequestModels;
using MQtraining.Shared.ResponseModels;
using System;
using System.Threading.Tasks;

namespace MQtraining.Services.Features.Items.Commands.CreateItem
{
    public class CreateItemHandler : ICreateItemService
    {
        private readonly IMapper _mapper;
        private readonly IItemRepository _itemRepository;

        public CreateItemHandler(IMapper mapper, IItemRepository itemRepository)
        {
            _mapper = mapper;
            _itemRepository = itemRepository;
        }

        public async Task<ItemResponse> CreateItem(ItemRequest itemRequest)
        {
            var item = new Item()
            {
                ItemId = new Guid(),
                Name = itemRequest.Name,
                Price = itemRequest.Price

            };

            await _itemRepository.AddAsync(item);
            return _mapper.Map<ItemResponse>(item);

        }
    }
}
