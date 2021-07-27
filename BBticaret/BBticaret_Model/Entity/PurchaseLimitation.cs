using BBticaret_Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class PurchaseLimitation:BaseEntity
    {
        //public PurchaseLimitation()
        //{
        //    PurchaseLimitationItems = new HashSet<PurchaseLimitationItem>();
        //}
        public string Name { get; set; }
        public int MinimumLimit { get; set; }
        public int MaximumLimit { get; set; }
        public PurchaseLimitationType Type { get; set; }
        public bool Status { get; set; }
        //public ICollection<PurchaseLimitationItem> PurchaseLimitationItems { get; set; }
    }
}
