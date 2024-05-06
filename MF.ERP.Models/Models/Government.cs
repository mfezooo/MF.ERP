namespace MF.ERP.Models
{
    public class Government : BaseEntityWithNameArEn
    {
        public int CountryId { get; set; } = 1;
        public virtual IEnumerable<Area>? Areas { get; set; }
    }
}
