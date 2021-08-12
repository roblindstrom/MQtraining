using MQtraining.Services.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQtraining.Services.ViewModels
{
    public class ViewOrder
    {
        public Guid OrderId { get; set; }

        public Guid Password { get; set; }

        public IEnumerable<DTOLineItem> LineItems  { get; set; }
    }
}
