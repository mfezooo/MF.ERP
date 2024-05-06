using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}