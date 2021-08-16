using MQtraining.Shared.IRepository;
using MQtraining.Shared.Models;

namespace MQtraining.Data.Repositories
{
    public class ItemRepository : BaseRepository<Item>, IItemRepository
    {
        protected new readonly MQtrainingDbContext _MQtrainingDbContext;
        public ItemRepository(MQtrainingDbContext mqtrainingDbContext) : base(mqtrainingDbContext)
        {
            _MQtrainingDbContext = mqtrainingDbContext;
        }

    }
}
