using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class PurchaseLimitationItem:BaseEntity
    {
        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [ForeignKey("PurchaseLimitation")]
        public int LimitationId { get; set; }
        public PurchaseLimitation PurchaseLimitation { get; set; }
        [ForeignKey("MemberGroup")]
        public int MemberGroupId { get; set; }
        public MemberGroup MemberGroup { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
