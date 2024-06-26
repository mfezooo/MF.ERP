﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.ERP.Models
{
    public class Customer : BaseEntityWithNameArEn
    { 
        public string Email { get; set; } = string.Empty;
        public DateTime WarehouseAvilableTill { get; set; }  
        public string Address { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        public string CompaniesCompetation { get; set; } = string.Empty;
        public int Periority { get; set; }
        public int PaymentAllowedDays { get; set; } 
        public int CustomerTypeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsBlocked { get; set; } 
        public string EndReason { get; set; } = string.Empty;
        public int AreaId { get; set; }
        public int IndustryId { get; set; }
        public int StatusId { get; set; }
        public int RepresentiveId { get; set; }
        public CustomerType CustomerType { get; set; } = null!;
        public Area? Area  { get; set; }
        public Industry? Industry  { get; set; }
        public CustomerStatus? LastStatus  { get; set; }
        public Representive? Representive  { get; set; }
        public IEnumerable<ContactPerson>? ContactPersons { get; set; }
        public IEnumerable<ActionsMaster>? ActionsMasters { get; set; }
    }
}
