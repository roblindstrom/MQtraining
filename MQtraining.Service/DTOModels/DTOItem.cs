using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQtraining.Services.DTOModels
{
    public class DTOItem
    {
        public Guid ItemId { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }
    }
}
