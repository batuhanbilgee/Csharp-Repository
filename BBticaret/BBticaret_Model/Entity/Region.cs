using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class Region:BaseEntity
    {
        //public Region()
        //{
        //    Locations = new HashSet<Location>();
        //    ShippingRates = new HashSet<ShippingRate>();
        //}
        public string Name { get; set; }
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public Country Country { get; set; }


        //public ICollection<Location> Locations { get; set; }
        //public ICollection<ShippingRate> ShippingRates { get; set; }
    }
}
