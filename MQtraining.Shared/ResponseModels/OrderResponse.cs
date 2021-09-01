using System;
using System.Collections.Generic;

namespace MQtraining.Shared.ResponseModels
{
    public class OrderResponse
    {
        public Guid OrderId { get; set; }

        public Guid Password { get; set; }

        public ICollection<LineItemResponse> LineItems { get; set; }
    }
}
