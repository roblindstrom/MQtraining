using AutoMapper;
using MQtraining.Shared.DTOModels;
using MQtraining.Shared.Models;
using MQtraining.Shared.RequestModels;
using MQtraining.Shared.ResponseModels;

namespace MQtraining.Services
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            // Order Maps
            CreateMap<OrderResponse, OrderRequest>();
            CreateMap<Order, OrderRequest>();
            CreateMap<Order, OrderResponse>();
            CreateMap<OrderRequest, Order>();
            CreateMap<Order, DTOOrder>();

            //Item Maps
            CreateMap<ItemResponse, ItemRequest>();
            CreateMap<Item, ItemRequest>();
            CreateMap<Item, ItemResponse>();
            CreateMap<ItemRequest, Item>();
            CreateMap<Item, DTOItem>();
            CreateMap<ItemRequest, ItemResponse>();

            //LineItem Maps
            CreateMap<LineItem, LineItemRequest>();
            CreateMap<LineItem, LineItemResponse>();
            CreateMap<DTOLineItem, LineItem>();
            CreateMap<LineItem, DTOLineItem>();
            CreateMap<LineItemRequest, LineItem>();

        }
    }
}
