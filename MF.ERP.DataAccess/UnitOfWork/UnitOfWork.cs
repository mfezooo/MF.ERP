using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.ERP.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            CustomerRepository = new CustomerRepository(_db);
            CustomerTypeRepository = new CustomerTypeRepository(_db);
        }
        public ICustomerRepository CustomerRepository { get; set; }
        public ICustomerTypeRepository CustomerTypeRepository { get; set; }



        public IEnumerable<TB> ExecuteStored<TB>(string sql) where TB : class
        {
            try
            {
                var result = _db.Set<TB>().FromSqlRaw(sql).ToList();
                return result;
            }
            catch (Exception e)
            {

                throw;
            }

        }
        public void Save()
        {
            _db.SaveChanges();
        }
        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}