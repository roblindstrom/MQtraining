using AutoMapper;
using MQtraining.Shared.RequestModels;
using MQtraining.Shared.ResponseModels;

namespace MQtraining.UI
{
    public class MappingProfileBlazor : Profile
    {
        public MappingProfileBlazor()
        {
            //Item Maps
            CreateMap<ItemResponse, ItemRequest>();
            CreateMap<ItemRequest, ItemResponse>();

            //Order Maps
            CreateMap<OrderResponse, OrderRequest>();
            CreateMap<OrderRequest, OrderResponse>();
        }
    }
}
