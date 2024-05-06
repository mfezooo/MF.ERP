using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}