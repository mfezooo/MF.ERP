using MF.ERP.Models;

namespace MF.ERP.DataAccess
{
    public interface ICustomerRepository : IRepository<Customer>
    {
    }
    public interface ICustomerTypeRepository : IRepository<CustomerType>
    {
    }
}
