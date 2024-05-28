using System.ComponentModel.DataAnnotations.Schema;

namespace MF.ERP.Models
{ 
    public class ActionsMaster : BaseEntity
    {
        public string? Notes { get; set; }
      
        public decimal ExpectedRevenue { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? ExpectedEndDate { get; set; }
        public int ActionStatusId { get; set; }
        [ForeignKey("ActionStatusId")]
        public ActionStatus ActionStatus { get; set; } = null!;
      
        public int RepresentiveId { get; set; }
        [ForeignKey("RepresentiveId")]
        public virtual Representive Representive { get; set; } = null!;
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; } = null!;

        public int? ActionRefranceId { get; set; }
        [ForeignKey("ActionRefranceId")]
        public ActionsMaster? ActionRefrance { get; set; }

        public int? OfferPriceId { get; set; }
        public int? PurchasingOrderId { get; set; }
        public int? OrderId { get; set; }

        public virtual ICollection<ActionsDetails>?  Details { get; set; } 


    }
}
