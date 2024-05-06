using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}