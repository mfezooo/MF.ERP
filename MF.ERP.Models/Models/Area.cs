using System.ComponentModel.DataAnnotations.Schema;

namespace MF.ERP.Models
{
    public class Area : BaseEntityWithNameArEn
    { 
        public int? GovernmentId { get; set; }
        [ForeignKey("GovernmentId")]
        public Government? Government { get; set; }  
    }
}
