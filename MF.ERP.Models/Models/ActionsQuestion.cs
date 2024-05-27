using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.ERP.Models
{
    public class ActionsQuestion : BaseEntity
    {
        public int QuestionId { get; set; }
        public int ActionsId { get; set; }
        public string Answer { get; set; } = string.Empty;
        public virtual Question Question { get; set; }
        public ActionsMaster Actions { get; set; }
    }
}
