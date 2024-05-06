using MF.ERP.Models; 
namespace MF.ERP.DataAccess
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext _Context ) : base(_Context) 
        {
        }
    }
}