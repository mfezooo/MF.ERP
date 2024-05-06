using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class CustomerStatusRepository : Repository<CustomerStatus>, ICustomerStatusRepository
    {
        public CustomerStatusRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}