using MQtraining.Shared.DTOModels;
using System;
using System.Collections.Generic;

namespace MQtraining.Shared.ResponseModels
{
    public class OrderResponse
    {
        public Guid OrderId { get; set; }

        public Guid Password { get; set; }

        public IEnumerable<DTOLineItem> Items { get; set; }
    }
}
