using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class ActionsMasterRepository : Repository<ActionsMaster>, IActionsMasterRepository
    {
        public ActionsMasterRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}