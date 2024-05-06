using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class PaymentMethoudRepository : Repository<PaymentMethoud>, IPaymentMethoudRepository
    {
        public PaymentMethoudRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}