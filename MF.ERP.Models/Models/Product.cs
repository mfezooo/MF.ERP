using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.ERP.Models.Models
{
    public class Product : BaseEntity
    { 
        public string Spects { get; set; } = string.Empty;
        public int? PackId { get; set; }
        public string Pack { get; set; } = string.Empty;
        public decimal SellPrice { get; set; }
        public decimal BuyPrice { get; set; } 
        public decimal Quantity { get; set; }
        public decimal AvilableQuantity { get; set; }
    }
}
