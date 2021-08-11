using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQtraining.Services.ViewModels
{
    public class ViewItem
    {
        public Guid ItemId { get; set; }

        public int Quantity { get; set; }

        public ViewOrder Order { get; set; }
    }
}
