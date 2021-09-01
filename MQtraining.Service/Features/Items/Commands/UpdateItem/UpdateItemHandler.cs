using AutoMapper;
using MQtraining.Shared.IRepository;
using MQtraining.Shared.Models;
using MQtraining.Shared.RequestModels;
using MQtraining.Shared.ResponseModels;
using System.Threading.Tasks;

namespace MQtraining.Services.Features.Items.Commands.UpdateItem
{
    public class UpdateItemHandler : IUpdateItemService
    {
        private readonly IItemRepository _itemRepository;
        private readonly IMapper _mapper;

        public UpdateItemHandler(IItemRepository itemRepository, IMapper mapper)
        {
            _itemRepository = itemRepository;
            _mapper = mapper;
        }

        public async Task<ItemResponse> UpdateItem(ItemRequest itemRequest)
        {

            var editedItem = new Item()
            {
                ItemId = itemRequest.ItemId,
                Name = itemRequest.Name,
                Price = itemRequest.Price
            };

            await _itemRepository.UpdateAsync(editedItem);
            return _mapper.Map<ItemResponse>(editedItem);
        }
    }
}
