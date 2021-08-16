using MQtraining.Shared.DTOModels;
using System;
using System.Collections.Generic;

namespace MQtraining.Shared.CommandModels
{
    public class OrderCommand
    {
        public Guid OrderId { get; set; }

        public Guid Password { get; set; }

        public IEnumerable<DTOLineItem> LineItems { get; set; }
    }
}
