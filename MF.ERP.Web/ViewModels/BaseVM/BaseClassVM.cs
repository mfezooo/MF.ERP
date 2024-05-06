namespace MF.ERP.Web
{
    public class BaseClassVM
    {
        public int Id { get; set; }
        public string UserCreated { get; set; } = string.Empty; 
        public bool? IsDeleted { get; set; } = false;
        public DateTime? LastModifiedDate { get; set; }
        public string? ModifyBy { get; set; }
        public int? ModifyCount { get; set; }
        public int OrderBy { get; set; }
    }
    public class BaseClassWithNameArEnVM : BaseClassVM
    {
        public string NameAr { get; set; } = string.Empty;
        public string NameEn { get; set; } = string.Empty;
    }
}
