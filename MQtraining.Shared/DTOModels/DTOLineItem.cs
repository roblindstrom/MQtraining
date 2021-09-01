using System;

namespace MQtraining.Shared.DTOModels
{
    public class DTOLineItem
    {
        public Guid ItemId { get; set; }

        public Guid OrderId { get; set; }

        public int Quantity { get; set; }
    }
}
