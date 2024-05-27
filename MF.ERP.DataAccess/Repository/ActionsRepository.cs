using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class ActionsRepository : Repository<ActionsMaster>, IActionsRepository
    {
        public ActionsRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}