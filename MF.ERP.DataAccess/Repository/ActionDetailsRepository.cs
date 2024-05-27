using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class ActionDetailsRepository : Repository<ActionsDetails>, IActionDetailsRepository
    {
        public ActionDetailsRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}