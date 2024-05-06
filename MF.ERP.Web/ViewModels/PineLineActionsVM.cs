namespace MF.ERP.Web
{
    public class PineLineActionsVM : BaseClassWithNameArEnVM
    {
        public int PipeLineId { get; set; }
        public int ActionId { get; set; }
        public DateTime ActionDate { get; set; }
        public string Comment { get; set; } = string.Empty;
        public int NextActionId { get; set; }
        public DateTime NextActionDate { get; set; } 
    }
}
