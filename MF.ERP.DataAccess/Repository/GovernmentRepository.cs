using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class GovernmentRepository : Repository<Government>, IGovernmentRepository
    {
        public GovernmentRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}