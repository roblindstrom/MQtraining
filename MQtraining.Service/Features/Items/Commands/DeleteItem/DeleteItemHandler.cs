using AutoMapper;
using MQtraining.Shared.IRepository;
using MQtraining.Shared.Models;
using MQtraining.Shared.RequestModels;
using MQtraining.Shared.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
