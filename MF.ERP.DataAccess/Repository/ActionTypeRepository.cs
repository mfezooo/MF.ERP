using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class ActionTypeRepository : Repository<ActionType>, IActionTypeRepository
    {
        public ActionTypeRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}