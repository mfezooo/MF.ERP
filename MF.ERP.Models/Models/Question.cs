using System.ComponentModel.DataAnnotations.Schema;

namespace MF.ERP.Models
{
    public class Question : BaseEntityWithNameArEn
    {
        public int IndustryId { get; set; }
        [ForeignKey("IndustryId")]
        public Industry Industry { get; set; }
    }
    public class VisitQuestion : BaseEntity
    {
        public int QuestionId { get; set; }
        public int VisitId { get; set; }
        public bool isAccept { get; set; }
        public string Answer { get; set; } = string.Empty;
    }
}
