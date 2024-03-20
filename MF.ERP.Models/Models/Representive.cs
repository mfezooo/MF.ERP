namespace MF.ERP.Models
{
    public class Representive : BaseEntityWithNameArEn
    { 
        public string Email { get; set; } = string.Empty;
        public bool? IsLocked { get; set; }  
        public DateTime? LockDate { get; set; } 
        public virtual IEnumerable<Customer>? Customers { get; set; } 
    }

}
