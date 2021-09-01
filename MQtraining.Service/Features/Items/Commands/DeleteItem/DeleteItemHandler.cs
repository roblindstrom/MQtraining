using MQtraining.Shared.IRepository;
using System;
using System.Threading.Tasks;

namespace MQtraining.Services.Features.Items.Commands.DeleteItem
{
    public class DeleteItemHandler : IDeleteItemService
    {

        private readonly IItemRepository _itemRepository;

        public DeleteItemHandler(IItemRepository itemRepository)
        {

            _itemRepository = itemRepository;
        }

        public async Task<Guid> DeleteItem(Guid itemId)
        {
            var ItemToBeDeleted = await _itemRepository.GetByIdAsync(itemId);
            await _itemRepository.DeleteAsync(ItemToBeDeleted);

            return ItemToBeDeleted.ItemId;
        }
    }
}
