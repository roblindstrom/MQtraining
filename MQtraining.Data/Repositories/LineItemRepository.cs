using MQtraining.Shared.IRepository;
using MQtraining.Shared.Models;
using MQtraining.Shared.RequestModels;
using MQtraining.Shared.ResponseModels;
using System;
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
