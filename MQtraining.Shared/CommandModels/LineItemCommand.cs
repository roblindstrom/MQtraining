using MQtraining.Shared.DTOModels;
using System;

namespace MQtraining.Shared.CommandModels
{
    public class LineItemCommand
    {
        public Guid LineItemId { get; set; }

        public int Quantity { get; set; }

        public DTOOrder Order { get; set; }
        public DTOItem Item { get; set; }
    }
}
