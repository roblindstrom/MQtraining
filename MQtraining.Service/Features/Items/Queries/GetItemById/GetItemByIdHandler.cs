using AutoMapper;
using MQtraining.Shared.IRepository;
using MQtraining.Shared.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQtraining.Services.Features.Items.Queries.GetItemById
{
    public class GetItemByIdHandler : IGetItemByIdService
    {
        private readonly IItemRepository _itemRepository;
        private readonly IMapper _mapper;

        public GetItemByIdHandler(IItemRepository itemRepository, IMapper mapper)
        {
            _itemRepository = itemRepository;
            _mapper = mapper;
        }

        public async Task<ItemResponse> GetItemById(Guid itemId)
        {
            var item = await _itemRepository.GetByIdAsync(itemId);
            
            return _mapper.Map<ItemResponse>(item);

        }

        
    }
}
