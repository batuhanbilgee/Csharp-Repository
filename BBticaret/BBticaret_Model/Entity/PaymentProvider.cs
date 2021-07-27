using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class PaymentProvider:BaseEntity
    {
        //public PaymentProvider()
        //{
        //    PaymentGateways = new HashSet<PaymentGateway>();
        //}
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        [ForeignKey("PaymentType")]
        public int PaymentTypeId { get; set; }
        public PaymentType PaymentType { get; set; }
        [ForeignKey("PaymentProviderSetting")]
        public int PaymentProviderSettingId { get; set; }
        public PaymentProviderSetting PaymentProviderSetting { get; set; }
        //public ICollection<PaymentGateway> PaymentGateways { get; set; }
    }
}
