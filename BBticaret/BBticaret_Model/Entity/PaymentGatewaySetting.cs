using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class PaymentGatewaySetting:BaseEntity
    {
        public string Varkey { get; set; }
        public string VarValue { get; set; }
        [ForeignKey("PaymentGateway")]
        public int PaymentGatewayId { get; set; }
        public PaymentGateway PaymentGateway { get; set; }
    }
}
