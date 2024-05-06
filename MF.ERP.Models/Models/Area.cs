namespace MF.ERP.Models
{
    public class Area : BaseEntityWithNameArEn
    { 
        public int GovernmentId { get; set; } 
        public Government? Government { get; set; }  
    }
}
