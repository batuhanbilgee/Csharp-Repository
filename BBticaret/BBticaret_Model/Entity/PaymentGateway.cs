using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class PaymentGateway:BaseEntity
    {
        //public PaymentGateway()
        //{
        //    PaymentGatewaySettings = new HashSet<PaymentGatewaySetting>();
        //    InstallmentRates = new HashSet<InstallmentRate>();
        //}
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public float SortOrder { get; set; }
        [ForeignKey("PaymentProvider")]
        public int PaymentProviderId { get; set; }
        public PaymentProvider PaymentProvider { get; set; }
        //public ICollection<PaymentGatewaySetting> PaymentGatewaySettings { get; set; }
        //public ICollection<InstallmentRate> InstallmentRates { get; set; }
    }
}
