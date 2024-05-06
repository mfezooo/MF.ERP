using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class ActionStatusRepository : Repository<ActionStatus>, IActionStatusRepository
    {
        public ActionStatusRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}