using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class ShippingProviderSetting:BaseEntity
    {
        public string VarKey { get; set; }
        public string VarValue { get; set; }
        [ForeignKey("ShippingProvider")]
        public int ShippingProviderId { get; set; }
        public ShippingProvider ShippingProvider { get; set; }
    }
}
