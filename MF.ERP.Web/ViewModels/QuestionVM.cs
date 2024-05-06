namespace MF.ERP.Web
{
    public class QuestionVM : BaseClassWithNameArEnVM
    {
        public int IndustryId { get; set; }
        public int QuestionId { get; set; }
        public int VisitId { get; set; }
        public bool isAccept { get; set; }
        public string Answer { get; set; } = string.Empty;
    }
}
