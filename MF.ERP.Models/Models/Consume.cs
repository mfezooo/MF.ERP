using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.ERP.Models
{
    public class Consume:BaseEntity
    {
        public int CustomerId { get; set; }
        public int? ProductId { get; set; }
        public int ProductName { get; set; }
        public decimal Quantity { get; set; }
    }

}
