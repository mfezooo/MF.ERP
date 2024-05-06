namespace MF.ERP.DataAccess
{
    public interface IUnitOfWork
    {
        ICustomerRepository CustomerRepository { get; }
        ICustomerTypeRepository CustomerTypeRepository { get; }



        IEnumerable<TB> ExecuteStored<TB>(string sql) where TB : class;
        void Save();
        Task SaveAsync();

    }
}
