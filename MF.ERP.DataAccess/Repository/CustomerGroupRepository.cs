using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class CustomerGroupRepository : Repository<CustomerGroup>, ICustomerGroupRepository
    {
        public CustomerGroupRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}