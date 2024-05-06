using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class JobRepository : Repository<Job>, IJobRepository
    {
        public JobRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}