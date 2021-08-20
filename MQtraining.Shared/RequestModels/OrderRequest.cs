using MQtraining.Shared.DTOModels;
using System;
using System.Collections.Generic;

namespace MQtraining.Shared.RequestModels
{
    public class OrderRequest
    {
        public OrderRequest()
        {
            LineItems = new List<LineItemRequest>();
        }

        public Guid OrderId { get; set; }

        public Guid Password { get; set; }

        public ICollection<LineItemRequest> LineItems { get; set; }
    }
}
