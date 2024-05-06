using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class PipeLineRepository : Repository<PipeLine>, IPipeLineRepository
    {
        public PipeLineRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}