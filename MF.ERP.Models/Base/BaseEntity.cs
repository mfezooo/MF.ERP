using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.ERP.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserCreated { get; set; } = string.Empty;
        public DateTime? CreatedDateTime { get; set; } = DateTime.Now;
        public bool? IsDeleted { get; set; } = false;
        public DateTime? LastModifiedDate { get; set; }
        public string? ModifyBy { get; set; }
        public int? ModifyCount { get; set; }
        public int OrderBy { get; set; }
    }
    public class BaseEntityWithNameArEn : BaseEntity
    {
        public string NameAr { get; set; } = string.Empty;
        public string NameEn { get; set; } = string.Empty;
    }
}
