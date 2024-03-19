
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.ERP.Models
{
    public class Customer : BaseEntity
    {
        public string NameAr { get; set; } = string.Empty;
        public string NameEn { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string WarehouseAvilableTill { get; set; } = string.Empty;
        public int AreaId { get; set; }
        public int IndustryId { get; set; }
        public int Periority { get; set; }
        public int StatusId { get; set; }
        public int RepresentiveId { get; set; }
        public decimal ExcpectedRevenue { get; set; }
        public IEnumerable<ContactPerson>? ContactPersons { get; set; }
    }
}
