using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class TitleRepository : Repository<Title>, ITitleRepository
    {
        public TitleRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}