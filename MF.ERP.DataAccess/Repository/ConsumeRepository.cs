using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class ConsumeRepository : Repository<Consume>, IConsumeRepository
    {
        public ConsumeRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}