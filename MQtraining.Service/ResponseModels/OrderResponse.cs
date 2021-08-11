using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQtraining.Services.ResponseModels
{
    public class OrderResponse
    {
        public Guid OrderId { get; set; }

        public Guid Password { get; set; }

        public IEnumerable<ItemResponse> Items { get; set; }
    }
}
