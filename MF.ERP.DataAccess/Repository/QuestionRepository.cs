using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class QuestionRepository : Repository<Question>, IQuestionRepository
    {
        public QuestionRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}