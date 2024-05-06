namespace MF.ERP.Web
{
    public class RepresintiveTargetVM : BaseClassWithNameArEnVM
    {
        public int RepresentiveId { get; set; }
        public DateTime StartTartgetTime { get; set; }
        public DateTime EndTartgetTime { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AmountAtEndOfDuration { get; set; }
        public int? TartgetTypeId { get; set; }
        //public Representive Representive { get; set; } = null!; 
        //public TartgetType? TartgetType { get; set; }
    }
}
