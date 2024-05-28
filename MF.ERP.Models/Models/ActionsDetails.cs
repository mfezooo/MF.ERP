using System.ComponentModel.DataAnnotations.Schema;

namespace MF.ERP.Models
{
    public class ActionsDetails : BaseEntity 
    {
        public int ActionsMasterId { get; set; }
        public DateTime? PlanedDate { get; set; }
        public DateTime? ActualDate { get; set; }
        public int? ActionId { get; set; }
        public DateTime? ActionDate { get; set; }
        public int? ActionTypeId { get; set; }
        [ForeignKey("ActionTypeId")]
        public ActionType? ActionType { get; set; }
        public int? NextActionId { get; set; }
        [ForeignKey("NextActionId")]
        public ActionType? NextActionTpe  { get; set; }
        public DateTime? NextActionDate { get; set; }        
        public int? ActionDetailStatusId { get; set; }
        [ForeignKey("ActionDetailStatusId")]
        public ActionDetailStatus? ActionDetailStatus { get; set; }
        public bool? isConsumeRecorded { get; set; }
        public string Result { get; set; } =string.Empty;
        public bool? IsApprovedByManager { get; set; }
        public string LocationWhenWithCustomer { get; set; } =string.Empty;
        public virtual ActionsMaster ActionsMaster { get; set; } = null!; 
    }
}
