using System;

namespace MQtraining.Shared.RequestModels
{
    public class LineItemRequest
    {
        public Guid ItemId { get; set; }

        public Guid OrderId { get; set; }

        public int Quantity { get; set; }

        public ItemRequest Item { get; set; }
    }
}
