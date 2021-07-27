using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class PaymentProviderSetting:BaseEntity
    {
        //public PaymentProviderSetting()
        //{
        //    PaymentProviders = new HashSet<PaymentProvider>();
        //}
        public string Varkey { get; set; }
        public string VarValue { get; set; }
        //public ICollection<PaymentProvider> PaymentProviders { get; set; }
    }
}
