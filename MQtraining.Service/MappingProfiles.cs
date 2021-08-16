using AutoMapper;
using MQtraining.Shared.CommandModels;
using MQtraining.Shared.DTOModels;
using MQtraining.Shared.Models;
using MQtraining.Shared.ResponseModels;

namespace MQtraining.Services
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            // Order Maps
            CreateMap<OrderResponse, OrderCommand>();
            CreateMap<Order, OrderCommand>();
            CreateMap<Order, OrderResponse>();
            CreateMap<OrderCommand, Order>();

            //Item Maps
            CreateMap<ItemResponse, ItemCommand>();
            CreateMap<Item, ItemCommand>();
            CreateMap<Item, ItemResponse>();
            CreateMap<ItemCommand, Item>();

            //LineItem Maps
            CreateMap<LineItem, LineItemCommand>();
            CreateMap<LineItem, LineItemResponse>();
            CreateMap<DTOLineItem, LineItem>();
            CreateMap<LineItem, DTOLineItem>();





        }
    }
}
