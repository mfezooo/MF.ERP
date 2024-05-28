using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class OrderStatusRepository : Repository<OrderStatus>, IOrderStatusRepository
    {
        public OrderStatusRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}