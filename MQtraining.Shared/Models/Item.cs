using System;
using System.Collections.Generic;

namespace MQtraining.Shared.Models
{
    public class Item
    {
        public Guid ItemId { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public IEnumerable<LineItem> LineItems { get; set; }

    }
}