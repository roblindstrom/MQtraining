using System;

namespace MQtraining.Shared.RequestModels
{
    public class ItemRequest
    {
        public Guid ItemId { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

    }
}
