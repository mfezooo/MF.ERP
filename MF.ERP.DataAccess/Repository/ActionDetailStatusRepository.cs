using MF.ERP.Models;
namespace MF.ERP.DataAccess
{
    public class ActionDetailStatusRepository : Repository<ActionDetailStatus>, IActionDetailStatusRepository
    {
        public ActionDetailStatusRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}