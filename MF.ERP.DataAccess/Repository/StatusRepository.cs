using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class StatusRepository : Repository<Status>, IStatusRepository
    {
        public StatusRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}