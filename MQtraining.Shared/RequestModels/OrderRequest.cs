using MQtraining.Shared.DTOModels;
using System;
using System.Collections.Generic;

namespace MQtraining.Shared.RequestModels
{
    public class OrderRequest
    {
        public Guid OrderId { get; set; }

        public Guid Password { get; set; }

        public IEnumerable<DTOLineItem> LineItems { get; set; }
    }
}
