using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class PaymentPlanRepository : Repository<PaymentPlan>, IPaymentPlanRepository
    {
        public PaymentPlanRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}