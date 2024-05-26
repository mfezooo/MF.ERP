using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class TargetTypeRepository : Repository<TargetType>, ITargetTypeRepository
    {
        public TargetTypeRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}