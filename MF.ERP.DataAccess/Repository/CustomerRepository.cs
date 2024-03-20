using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.ERP.DataAccess 
{
    public class CustomerRepository : Repository<CustomerRepository>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}