using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class TartgetTypeRepository : Repository<TartgetType>, ITartgetTypeRepository
    {
        public TartgetTypeRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}