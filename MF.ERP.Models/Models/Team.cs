namespace MF.ERP.Models
{
    public class Team : BaseEntityWithNameArEn
    { 
        public int? TartgetTypeId { get; set; }
        public TeamTarget? TartgetType { get; set; }
        public virtual IEnumerable<TeamArea>? TeamAreas { get; set; }
    }

}
