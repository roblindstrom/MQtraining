using System;

namespace MQtraining.Shared.Models
{
    public class Item
    {
        public Guid ItemId { get; set; }

        public int Quantity { get; set; }

        public Order Order { get; set; }


    }
}