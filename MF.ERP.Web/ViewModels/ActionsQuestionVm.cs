using MF.ERP.Web;
namespace MF.ERP.ViewModels
{
    public class ActionsQuestionVm : BaseClassVM
    {
        public int ActionsQuestionID { get; set; }
        public int ActionsQuestionName { get; set; }
        public int QuestionId { get; set; }
        public int QuestionName { get; set; }
        public int ActionsId { get; set; }
        public string Answer { get; set; } = string.Empty;
    }
}
