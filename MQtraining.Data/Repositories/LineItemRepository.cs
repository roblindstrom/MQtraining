using MQtraining.Shared.IRepository;
using MQtraining.Shared.Models;

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
