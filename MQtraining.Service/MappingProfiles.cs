using AutoMapper;
using MQtraining.Services.ResponseModels;
using MQtraining.Services.ViewModels;
using MQtraining.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQtraining.Services
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            // Order Maps
            CreateMap<OrderResponse, ViewOrder>();
            CreateMap<Order, ViewOrder>();
            CreateMap<Order, OrderResponse>();

            //Item Maps
            CreateMap<ItemResponse, ViewItem>();
            CreateMap<Item, ViewItem>();
            CreateMap<Item, ItemResponse>();

        }
    }
}
