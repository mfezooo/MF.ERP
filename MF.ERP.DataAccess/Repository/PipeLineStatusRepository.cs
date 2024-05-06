using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class PipeLineStatusRepository : Repository<PipeLineStatus>, IPipeLineStatusRepository
    {
        public PipeLineStatusRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}