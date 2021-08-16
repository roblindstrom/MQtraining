using AutoMapper;
using MQtraining.Shared.CommandModels;
using MQtraining.Shared.IRepository;
using MQtraining.Shared.Models;
using MQtraining.Shared.ResponseModels;
using System;
using System.Threading.Tasks;

namespace MQtraining.Services.Features.Items.Commands.CreateItem
{
    class CreateItemHandler : ICreateItemService
    {
        private readonly IMapper _mapper;
        private readonly IItemRepository _itemRepository;

        public CreateItemHandler(IMapper mapper, IItemRepository itemRepository)
        {
            _mapper = mapper;
            _itemRepository = itemRepository;
        }

        public async Task<ItemResponse> CreateItem(ItemCommand itemCommand)
        {
            var item = new Item()
            {
                ItemId = new Guid(),
                Name = itemCommand.Name,
                Price = itemCommand.Price

            };

            await _itemRepository.AddAsync(item);
            return _mapper.Map<ItemResponse>(item);

        }
    }
}
