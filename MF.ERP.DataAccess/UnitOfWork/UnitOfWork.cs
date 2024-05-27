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
            ActionsQuestionRepository = new ActionsQuestionRepository(db);
            CustomerRepository = new CustomerRepository(_db);
            CustomerTypeRepository = new CustomerTypeRepository(_db);
            ActionsRepository = new ActionsRepository(_db);
            ActionDetailsRepository = new ActionDetailsRepository(_db);          
            ActionStatusRepository = new ActionStatusRepository(_db);
            ActionTypeRepository = new ActionTypeRepository(_db);
            AreaRepository = new AreaRepository(_db);
            ConsumeRepository = new ConsumeRepository(_db);
            ContactPersonRepository = new ContactPersonRepository(_db);
            CustomerGroupRepository = new CustomerGroupRepository(_db);
            CustomerStatusRepository = new CustomerStatusRepository(_db);
            GovernmentRepository = new GovernmentRepository(_db);
            IndustryRepository = new IndustryRepository(_db);
            JobRepository = new JobRepository(_db);
            OrderRepository = new OrderRepository(_db);
            OrderDetailRepository = new OrderDetailRepository(_db);
            PaymentMethoudRepository = new PaymentMethoudRepository(_db);
            PaymentPlanRepository = new PaymentPlanRepository(_db);
            PaymentPlanDetailsRepository = new PaymentPlanDetailsRepository(_db);
            PineLineActionsRepository = new PineLineActionsRepository(_db);
            PipeLineRepository = new PipeLineRepository(_db);
            PipeLineStatusRepository = new PipeLineStatusRepository(_db);
            ProductRepository = new ProductRepository(_db);
            QuestionRepository = new QuestionRepository(_db);
            RepresentiveRepository = new RepresentiveRepository(_db);
            RepresintiveTargetRepository = new RepresintiveTargetRepository(_db);
            StatusRepository = new StatusRepository(_db);
            TargetTypeRepository = new TargetTypeRepository(_db);
           
            TitleRepository = new TitleRepository(_db);

        }
        public IActionsQuestionRepository ActionsQuestionRepository { get; set; }
        public ICustomerRepository CustomerRepository { get; set; }
        public ICustomerTypeRepository CustomerTypeRepository { get; set; }
        public IActionsRepository ActionsRepository { get; set; }
        public IActionStatusRepository ActionStatusRepository { get; set; }
        public IActionTypeRepository ActionTypeRepository { get; set; }
        public IAreaRepository AreaRepository { get; set; }
        public IConsumeRepository ConsumeRepository { get; set; }
        public IContactPersonRepository ContactPersonRepository { get; set; }
        public ICustomerGroupRepository CustomerGroupRepository { get; set; }
        public ICustomerStatusRepository CustomerStatusRepository { get; set; }
        public IGovernmentRepository GovernmentRepository { get; set; }
        public IIndustryRepository IndustryRepository { get; set; }
        public IJobRepository JobRepository { get; set; }
        public IOrderRepository OrderRepository { get; set; }
        public IOrderDetailRepository OrderDetailRepository { get; set; }
        public IPaymentMethoudRepository PaymentMethoudRepository { get; set; }
        public IPaymentPlanRepository PaymentPlanRepository { get; set; }
        public IPaymentPlanDetailsRepository PaymentPlanDetailsRepository { get; set; }
        public IPineLineActionsRepository PineLineActionsRepository { get; set; }
        public IPipeLineRepository PipeLineRepository { get; set; }
        public IPipeLineStatusRepository PipeLineStatusRepository { get; set; }
        public IProductRepository ProductRepository { get; set; }
        public IQuestionRepository QuestionRepository { get; set; }
        public IRepresentiveRepository RepresentiveRepository { get; set; }
        public IRepresintiveTargetRepository RepresintiveTargetRepository { get; set; }
        public IStatusRepository StatusRepository { get; set; }
        public ITargetTypeRepository TargetTypeRepository { get; set; } 
        public ITitleRepository TitleRepository { get; set; }

        public IActionDetailsRepository ActionDetailsRepository { get; set; }

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
        public int Save()
        {
            return _db.SaveChanges();
        }
        public async Task<int> SaveAsync()
        {
         return   await _db.SaveChangesAsync();
        }
    }
}