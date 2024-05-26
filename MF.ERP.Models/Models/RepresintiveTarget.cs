using System.ComponentModel.DataAnnotations.Schema;

namespace MF.ERP.Models
{
    public class RepresintiveTarget : BaseEntity
    { 
        public int RepresentiveId { get; set; }
        public Representive Representive { get; set; } = null!; 
        public DateTime StartTargetTime { get; set; }
        public DateTime EndTargetTime { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AmountAtEndOfDuration { get; set; }
        public int? TargetTypeId { get; set; }
        [ForeignKey("TargetTypeId")]
        public TargetType? TargetType { get; set; }
    }

}
