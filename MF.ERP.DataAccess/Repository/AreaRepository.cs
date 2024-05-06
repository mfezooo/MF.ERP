using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class AreaRepository : Repository<Area>, IAreaRepository
    {
        public AreaRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}