namespace MF.ERP.DataAccess
{
    public interface IUnitOfWork
    {
        IActionsQuestionRepository ActionsQuestionRepository { get; }
        ICustomerRepository CustomerRepository { get; }
        ICustomerTypeRepository CustomerTypeRepository { get; }
        IActionsRepository ActionsRepository { get; }
        IActionStatusRepository ActionStatusRepository { get; }
        IActionTypeRepository ActionTypeRepository { get; }
        IAreaRepository AreaRepository { get; }
        IConsumeRepository ConsumeRepository { get; }
        IContactPersonRepository ContactPersonRepository { get; } 
        ICustomerGroupRepository CustomerGroupRepository { get; }
        ICustomerStatusRepository CustomerStatusRepository { get; } 
        IGovernmentRepository GovernmentRepository { get; }
        IIndustryRepository IndustryRepository { get; }
        IJobRepository JobRepository { get; }
        IOrderRepository OrderRepository { get; }
        IOrderDetailRepository OrderDetailRepository { get; }
        IPaymentMethoudRepository PaymentMethoudRepository { get; }
        IPaymentPlanRepository PaymentPlanRepository { get; }
        IPaymentPlanDetailsRepository PaymentPlanDetailsRepository { get; }
        IPineLineActionsRepository PineLineActionsRepository { get; }
        IPipeLineRepository PipeLineRepository { get; }
        IPipeLineStatusRepository PipeLineStatusRepository { get; }
        IProductRepository ProductRepository { get; }
        IQuestionRepository QuestionRepository { get; }
        IRepresentiveRepository RepresentiveRepository { get; }
        IRepresintiveTargetRepository RepresintiveTargetRepository { get; }
        IStatusRepository StatusRepository { get; }
        ITargetTypeRepository TargetTypeRepository { get; }
        
        ITitleRepository TitleRepository { get; }



        IEnumerable<TB> ExecuteStored<TB>(string sql) where TB : class;
        int Save();
        Task<int> SaveAsync();

    }
}
