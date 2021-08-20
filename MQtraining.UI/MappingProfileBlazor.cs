using AutoMapper;
using MQtraining.Shared.RequestModels;
using MQtraining.Shared.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MQtraining.UI
{
    public class MappingProfileBlazor : Profile
    {
        public MappingProfileBlazor()
        {
            //Item Maps
            CreateMap<ItemResponse, ItemRequest>();
        }
    }
}
