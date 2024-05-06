using AutoMapper;
using MF.ERP.Models;
using MF.ERP.Service.DTO;
using System;

namespace MF.ERP.Web
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Customer, CustomerVM>().ReverseMap();
              
        }
    }
}