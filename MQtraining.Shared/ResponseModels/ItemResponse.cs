using System;
using System.ComponentModel.DataAnnotations;

namespace MQtraining.Shared.ResponseModels
{
    public class ItemResponse
    {
        public Guid ItemId { get; set; }
        
        public string Name { get; set; }

        public double Price { get; set; }
    }
}
