namespace MF.ERP.Models
{
    public class RepresintiveTeams : BaseEntity
    { 
        public int TeamId { get; set; }
        public int RepresintiveId { get; set; } 
        public bool isManager { get; set; } 
    }

}
