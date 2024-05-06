using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class RepresentiveRepository : Repository<Representive>, IRepresentiveRepository
    {
        public RepresentiveRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}