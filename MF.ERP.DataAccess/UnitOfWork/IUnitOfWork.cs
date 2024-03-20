namespace MF.ERP.DataAccess
{
    public interface IUnitOfWork
    {
        ICustomerRepository CustomerRepository { get; }

    }
}
