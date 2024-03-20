namespace MF.ERP.Models
{
    public class TeamTarget : BaseEntity
    { 
        public int TeamId { get; set; }
        public DateTime StartTartgetTime { get; set; }
        public DateTime EndTartgetTime { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AmountAtEndOfDuration { get; set; }
        public int? TartgetTypeId { get; set; }
        public TartgetType? TartgetType { get; set; }
    }

}
