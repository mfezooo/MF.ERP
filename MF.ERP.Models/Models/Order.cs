using System.ComponentModel.DataAnnotations.Schema;

namespace MF.ERP.Models
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; set; }
        public int RepresentiveId { get; set; }
        [ForeignKey("RepresentiveId")]
        public Representive Representive { get; set; } = null!;
        public DateTime DeleveryDate { get; set; }
        public DateTime ValidTo { get; set; }
        public int? PaymentMethoudId { get; set; }
        public PaymentMethoud? PaymentMethoud { get; set; }
        public int? PaymentPlanId { get; set; }
        [ForeignKey("PaymentPlanId")]
        public PaymentPlan? PaymentPlan { get; set; }
        public DateTime OfferPriceDate { get; set; }
        public DateTime ChangeToOrderDate { get; set; }
        public int? PipeLineId { get; set; }
        [ForeignKey("PipeLineId")]
        public PipeLine? PipeLine { get; set; }
        //User
        public int CrmMgrApprovedId { get; set; }
        public DateTime CrmMgrApprovedDate { get; set; }

        public int AccMgrApprovedId { get; set; }
        public DateTime AccMgrApprovedDate { get; set; }

        public int StockMgrApprovedId { get; set; }
        public DateTime StocMgrApprovedDate { get; set; }

        public int StatusId { get; set; }
        [ForeignKey("StatusId")]
        public  OrderStatus? OrderStatus { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
