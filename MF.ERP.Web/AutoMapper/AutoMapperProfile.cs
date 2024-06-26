﻿using AutoMapper;
using MF.ERP.Models; 
using MF.ERP.ViewModels;
namespace MF.ERP.Web
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            ActionsMapper();
            ActionStatusMapper();
            ActionTypeMapper();
            AreaMapper();
            ConsumeMapper();
            ContactPersonMapper();
            CustomerMapper();
            CustomerGroupMapper();
            CustomerStatusMapper();
            CustomerTypeMapper();
            GovernmentMapper();
            IndustryMapper();
            JobMapper();
            OrderMapper();
            OrderDetailMapper();
            PaymentMethoudMapper();
            PaymentPlanMapper();
            PaymentPlanDetailsMapper();
            PineLineActionsMapper();
            PipeLineMapper();
            PipeLineStatusMapper();
            ProductMapper();
            QuestionMapper();
            RepresentiveMapper();
            RepresintiveTargetMapper();
            StatusMapper();
            TartgetTypeMapper();  
            TitleMapper();
            ActionsQuestionMapper();
            ActionDetailStatusMapper();
        }
        private void ActionsMapper()
        {
            CreateMap<ActionsMasterVM, ActionsMaster>().ReverseMap();
            CreateMap<ActionsDetailsVM, ActionsDetails>().ReverseMap();
        }

        private void ActionStatusMapper()
        {
            CreateMap<ActionStatusVM, ActionStatus>().ReverseMap();
        }
        private void ActionDetailStatusMapper()
        {
            CreateMap<ActionDetailStatusVM, ActionDetailStatus>().ReverseMap();
        }

        private void ActionTypeMapper()
        {
            CreateMap<ActionTypeVM, ActionType>().ReverseMap();
        }

        private void AreaMapper()
        {
            CreateMap<AreaVM, Area>()
                   .ReverseMap()
                   .ForMember(d => d.GovernmentName, opt => opt.MapFrom(src =>src.Government!.NameAr))
                   
                   ;
        }

        private void ConsumeMapper()
        {
            CreateMap<ConsumeVM, Consume>().ReverseMap();
        }

        private void ContactPersonMapper()
        {
            CreateMap<ContactPersonVM, ContactPerson>().ReverseMap();
        }

        private void CustomerMapper()
        {
            CreateMap<CustomerVM, Customer>()
                   .ForMember(d => d.Id, opt => opt.MapFrom(src =>src.CustomerId)) 
                .ReverseMap();
        }

        private void CustomerGroupMapper()
        {
            CreateMap<CustomerGroupVM, CustomerGroup>().ReverseMap();
        }

        private void CustomerStatusMapper()
        {
            CreateMap<CustomerStatusVM, CustomerStatus>().ReverseMap();
        }

        private void CustomerTypeMapper()
        {
            CreateMap<CustomerTypeVM, CustomerType>().ReverseMap();
        }

        private void GovernmentMapper()
        {
            CreateMap<GovernmentVM, Government>().ReverseMap();
        }

        private void IndustryMapper()
        {
            CreateMap<IndustryVM, Industry>().ReverseMap();
        }

        private void JobMapper()
        {
            CreateMap<JobVM, Job>().ReverseMap();
        }

        private void OrderMapper()
        {
            CreateMap<OrderVM, Order>().ReverseMap();
        }

        private void OrderDetailMapper()
        {
            CreateMap<OrderDetailVM, OrderDetail>().ReverseMap();
        }

        private void PaymentMethoudMapper()
        {
            CreateMap<PaymentMethoudVM, PaymentMethoud>().ReverseMap();
        }

        private void PaymentPlanMapper()
        {
            CreateMap<PaymentPlanVM, PaymentPlan>().ReverseMap();
        }

        private void PaymentPlanDetailsMapper()
        {
            CreateMap<PaymentPlanDetailsVM, PaymentPlanDetails>().ReverseMap();
        }

        private void PineLineActionsMapper()
        {
            CreateMap<PineLineActionsVM, PineLineAction>().ReverseMap();
        }

        private void PipeLineMapper()
        {
            CreateMap<PipeLineVM, PipeLine>().ReverseMap();
        }

        private void PipeLineStatusMapper()
        {
            CreateMap<PipeLineStatusVM, PipeLineStatus>().ReverseMap();
        }

        private void ProductMapper()
        {
            CreateMap<ProductVM, Product>().ReverseMap();
        }

      

        private void RepresentiveMapper()
        {
            CreateMap<RepresentiveVM, Representive>().ReverseMap();
        }

       

        private void StatusMapper()
        {
            CreateMap<OrderStatusVM, OrderStatus>().ReverseMap();
        }

        private void TartgetTypeMapper()
        {
            CreateMap<TargetTypeVM, TargetType>().ReverseMap();
        }

        
        private void TitleMapper()
        {
            CreateMap<TitleVM, Title>().ReverseMap();
        }
        private void RepresintiveTargetMapper()
        {
            CreateMap<RepresintiveTargetVM,RepresintiveTarget>()
            
                .ReverseMap()
               .ForMember(dest => dest.RepresentiveName, opt => opt.MapFrom(src => src.Representive!.NameAr))
               .ForMember(dest => dest.TargetTypeName, opt => opt.MapFrom(src => src.TargetType!.NameAr))
                ; 
        }
        private void ActionsQuestionMapper()
        {
            CreateMap<ActionsQuestion, ActionsQuestionVm>()
               .ForMember(dest => dest.QuestionName, opt => opt.MapFrom(src => src.Question!.NameAr)) 
               .ReverseMap();
        }
        private void QuestionMapper()
        { 
            CreateMap<QuestionVM, Question>()
                  .ReverseMap()
                  .ForMember(d => d.IndustryName, opt => opt.MapFrom(src => src.Industry!.NameAr))

                  ;
        }
       
    }
}