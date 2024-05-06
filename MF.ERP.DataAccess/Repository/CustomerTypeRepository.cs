using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class CustomerTypeRepository : Repository<CustomerType>, ICustomerTypeRepository
    {
        public CustomerTypeRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}