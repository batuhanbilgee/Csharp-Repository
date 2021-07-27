using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class MemberGroup:BaseEntity
    {
        //public MemberGroup()
        //{
        //    Members = new HashSet<Member>();
        //    PurchaseLimitationItems = new HashSet<PurchaseLimitationItem>();
        //}
        public string Name { get; set; }
        public int PriceIndex { get; set; }
        public string AllowedPaymentGateways { get; set; }
        //public ICollection<Member> Members { get; set; }
        //public ICollection<PurchaseLimitationItem> PurchaseLimitationItems { get; set; }
    }
}
