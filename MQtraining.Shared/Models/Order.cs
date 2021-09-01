using System;
using System.Collections.Generic;

namespace MQtraining.Shared.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }

        public Guid Password { get; set; }

        public ICollection<LineItem> LineItems { get; set; }

    }
}
