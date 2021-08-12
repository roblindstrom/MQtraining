using MQtraining.Services.DTOModels;
using MQtraining.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQtraining.Services.ViewModels
{
    public class ViewLineItem
    {
        public Guid LineItemId { get; set; }

        public int Quantity { get; set; }

        public DTOOrder Order { get; set; }
        public DTOItem Item { get; set; }
    }
}
