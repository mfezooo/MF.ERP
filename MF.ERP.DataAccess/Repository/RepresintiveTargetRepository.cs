using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class RepresintiveTargetRepository : Repository<RepresintiveTarget>, IRepresintiveTargetRepository
    {
        public RepresintiveTargetRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}