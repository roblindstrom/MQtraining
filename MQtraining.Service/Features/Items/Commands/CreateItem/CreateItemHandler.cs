using AutoMapper;
using MQtraining.Services.ResponseModels;
using MQtraining.Services.ViewModels;
using MQtraining.Shared.IRepository;
using MQtraining.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public async Task<ItemResponse> CreateItem(ViewItem viewItem) 
        {
            var item = new Item()
            {
                ItemId = new Guid(),
                Name = viewItem.Name,
                Price = viewItem.Price

            };

            await _itemRepository.AddAsync(item);
            return _mapper.Map<ItemResponse>(item);

        }
    }
}
