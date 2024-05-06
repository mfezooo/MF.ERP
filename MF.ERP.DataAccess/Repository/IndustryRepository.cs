using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class IndustryRepository : Repository<Industry>, IIndustryRepository
    {
        public IndustryRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}