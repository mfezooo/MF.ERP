using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.ERP.DataAccess
{
    public class UnitOfWork
    {
        private ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            CustomerRepository = new CustomerRepository(_db);
        }
        public ICustomerRepository CustomerRepository { get; set; }

    }
}