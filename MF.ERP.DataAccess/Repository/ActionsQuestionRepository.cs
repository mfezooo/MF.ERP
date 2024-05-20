using MF.ERP.Models;
namespace MF.ERP.DataAccess
{
    public class ActionsQuestionRepository : Repository<ActionsQuestion>, IActionsQuestionRepository
    {
        public ActionsQuestionRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}