using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class InstallmentRate:BaseEntity
    {
        public int Installment { get; set; }
        public int Rate { get; set; }
        [ForeignKey("PaymentGateway")]
        public int PaymentGatewayId { get; set; }
        public PaymentGateway PaymentGateway { get; set; }
    }
}
