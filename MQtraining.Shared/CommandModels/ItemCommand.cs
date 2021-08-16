using System;

namespace MQtraining.Shared.CommandModels
{
    public class ItemCommand
    {
        public Guid ItemId { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

    }
}
