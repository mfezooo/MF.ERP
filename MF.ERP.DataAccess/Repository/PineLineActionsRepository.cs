using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class PineLineActionsRepository : Repository<PineLineAction>, IPineLineActionsRepository
    {
        public PineLineActionsRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}