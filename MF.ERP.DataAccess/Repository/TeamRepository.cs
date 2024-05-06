using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class TeamRepository : Repository<Team>, ITeamRepository
    {
        public TeamRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}