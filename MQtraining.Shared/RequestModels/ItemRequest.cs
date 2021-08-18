using System;
using System.ComponentModel.DataAnnotations;

namespace MQtraining.Shared.RequestModels
{
    public class ItemRequest
    {
        public Guid ItemId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }

    }
}
