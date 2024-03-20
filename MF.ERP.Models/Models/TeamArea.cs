namespace MF.ERP.Models
{
    public class TeamArea : BaseEntity
    {
        public int TeamId { get; set; }
        public Team Team  { get; set; }
        public int AreaId { get; set; }
        public Area Area  { get; set; }
     }

}
