using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class ContactPersonRepository : Repository<ContactPerson>, IContactPersonRepository
    {
        public ContactPersonRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}