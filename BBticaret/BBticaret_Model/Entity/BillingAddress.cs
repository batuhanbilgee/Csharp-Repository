using BBticaret_Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class BillingAddress:BaseEntity
    {
        //public BillingAddress()
        //{
        //    Orders = new HashSet<Order>();
        //    PreOrderInfos = new HashSet<PreOrderInfo>();
        //}
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Country { get; set; }
        public string Location { get; set; }
        public string SubLocation { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }
        public BillingAddressInvoiceType InvoiceType { get; set; }
        public string TaxNo { get; set; }
        public string TaxOffice { get; set; }
        public string IdentityRegistrationNumber { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }
        //public ICollection<Order> Orders { get; set; }
        //public ICollection<PreOrderInfo> PreOrderInfos { get; set; }

    }
}
