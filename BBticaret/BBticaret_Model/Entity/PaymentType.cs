using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class PaymentType:BaseEntity
    {
        //public PaymentType()
        //{
        //    PaymentProviders = new HashSet<PaymentProvider>();
        //}
        public string Name { get; set; }
        //public ICollection<PaymentProvider> PaymentProviders { get; set; }
    }
}
