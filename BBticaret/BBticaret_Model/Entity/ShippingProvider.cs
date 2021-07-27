using BBticaret_Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class ShippingProvider:BaseEntity
    {
        //public ShippingProvider()
        //{
        //    ShippingProviderSettings = new HashSet<ShippingProviderSetting>();
        //    ShippingCompanies = new HashSet<ShippingCompany>();
        //}
        public string Code { get; set; }
        public string Name { get; set; }
        public string TrackingUrl { get; set; }
        public ShippingProviderTrackingFormMethod TrackingFormMethod { get; set; }
        public string PayLoad { get; set; }

        //public ICollection<ShippingProviderSetting> ShippingProviderSettings { get; set; }
        //public ICollection<ShippingCompany> ShippingCompanies { get; set; }

    }
}
