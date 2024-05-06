namespace MF.ERP.Web
{
    public class RepresentiveVM : BaseClassWithNameArEnVM
    {
        public string Email { get; set; } = string.Empty;
        public bool? IsLocked { get; set; }  
        public DateTime? LockDate { get; set; } 
    }
}
