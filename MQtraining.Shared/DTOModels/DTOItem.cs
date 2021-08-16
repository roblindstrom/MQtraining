using System;

namespace MQtraining.Shared.DTOModels
{
    public class DTOItem
    {
        public Guid ItemId { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }
    }
}
