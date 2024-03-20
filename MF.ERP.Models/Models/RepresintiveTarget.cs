namespace MF.ERP.Models
{
    public class RepresintiveTarget : BaseEntity
    { 
        public int RepresentiveId { get; set; }
        public Representive Representive { get; set; } = null!; 
        public DateTime StartTartgetTime { get; set; }
        public DateTime EndTartgetTime { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AmountAtEndOfDuration { get; set; }
        public int? TartgetTypeId { get; set; }
        public TartgetType? TartgetType { get; set; }
    }

}
