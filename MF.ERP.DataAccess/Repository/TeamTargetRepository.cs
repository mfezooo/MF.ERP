using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class TeamTargetRepository : Repository<TeamTarget>, ITeamTargetRepository
    {
        public TeamTargetRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}