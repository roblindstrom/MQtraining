using MQtraining.Shared.IRepository;
using MQtraining.Shared.Models;

namespace MQtraining.Data.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        protected new readonly MQtrainingDbContext _MQtrainingDbContext;
        public OrderRepository(MQtrainingDbContext mqtrainingDbContext) : base(mqtrainingDbContext)
        {
            _MQtrainingDbContext = mqtrainingDbContext;
        }



    }
}
