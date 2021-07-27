using BBticaret_Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class ShippingCompany:BaseEntity
    {
        //public ShippingCompany()
        //{
        //    ShippingRates = new HashSet<ShippingRate>();
        //    PreOrderInfos = new HashSet<PreOrderInfo>();
        //}
        public string Name { get; set; }
        public ShippingCompanyStatus Status { get; set; }
        public float ExtraPrice { get; set; }
        public float ExtraVolumetricWeightPrice { get; set; }
        public float FreeShipmentOrderPrice { get; set; }
        public float FreeShipmentVolumetricWeightLimit { get; set; }
        public float SortOrder { get; set; }
        public string CompanyCode { get; set; }
        public ShippingCompanyPaymentType PaymentType { get; set; }
        [ForeignKey("ShippingProvider")]
        public int ShippingProviderId { get; set; }
        public ShippingProvider ShippingProvider { get; set; }
        //public ICollection<ShippingRate> ShippingRates { get; set; }
        //public ICollection<PreOrderInfo> PreOrderInfos { get; set; }
    }
}
