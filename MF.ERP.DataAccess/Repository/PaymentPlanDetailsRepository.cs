using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class PaymentPlanDetailsRepository : Repository<PaymentPlanDetails>, IPaymentPlanDetailsRepository
    {
        public PaymentPlanDetailsRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}