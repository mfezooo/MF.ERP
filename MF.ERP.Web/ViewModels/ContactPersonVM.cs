namespace MF.ERP.Web
{
    public class ContactPersonVM : BaseClassWithNameArEnVM
    {
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Priority { get; set; }
        public string Note { get; set; } = string.Empty;
        public int TitleId { get; set; }
        public int JobId { get; set; }
        public int CustomerId { get; set; }
        //public Title? Title  { get; set; } 
        //public Job? Job { get; set; }
        //public Customer Customer { get; set; } = null!;
    }
}
