using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQtraining.Services.DTOModels
{
    public class DTOLineItem
    {
        public Guid LineItemId { get; set; }

        public int Quantity { get; set; }
    }
}
