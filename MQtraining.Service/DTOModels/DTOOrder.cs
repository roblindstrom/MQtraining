using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQtraining.Services.DTOModels
{
    public class DTOOrder
    {
        public Guid OrderId { get; set; }

        public Guid Password { get; set; }
    }
}
