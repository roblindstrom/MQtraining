using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQtraining.Shared.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }

        public Guid Password { get; set; }

        public IEnumerable<Item> Items { get; set; }

    }
}
