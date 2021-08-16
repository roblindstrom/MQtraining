using System;

namespace MQtraining.Shared.Models
{
    public class LineItem
    {
        public Guid LineItemId { get; set; }

        public int Quantity { get; set; }

        public Order Order { get; set; }
        public Item Item { get; set; }
    }
}
