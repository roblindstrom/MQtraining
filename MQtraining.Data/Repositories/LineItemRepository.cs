using MQtraining.Shared.IRepository;
using MQtraining.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQtraining.Data.Repositories
{
    public class LineItemRepository : BaseRepository<LineItem>, ILineItemRepository
    {
        protected new readonly MQtrainingDbContext _MQtrainingDbContext;
        public LineItemRepository(MQtrainingDbContext mqtrainingDbContext) : base(mqtrainingDbContext)
        {
            _MQtrainingDbContext = mqtrainingDbContext;
        }

    }
}
