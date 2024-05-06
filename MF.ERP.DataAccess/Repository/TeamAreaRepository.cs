using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class TeamAreaRepository : Repository<TeamArea>, ITeamAreaRepository
    {
        public TeamAreaRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}