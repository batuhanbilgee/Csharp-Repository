using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class ShippingRate:BaseEntity
    {
        public int VolumetricWeightStart { get; set; }
        public int VolumetricWeightEnd { get; set; }
        public float Rate { get; set; }
        [ForeignKey("Region")]
        public int RegionId { get; set; }
        public Region Region { get; set; }
        [ForeignKey("ShippingCompany")]
        public int ShippingCompanyId { get; set; }
        public ShippingCompany ShippingCompany { get; set; }
    }
}
