
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.ERP.Models
{
    public class ContactPerson : BaseEntityWithNameArEn
    {
 
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Priority { get; set; }
        public string Note { get; set; } = string.Empty;
        public int TitleId { get; set; }
        public Title? Title  { get; set; } 
        public int JobId { get; set; }
        public Job? Job { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
    }
}
