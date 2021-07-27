using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class ProductButton:BaseEntity
    {
        public bool FastShipping { get; set; }
        public bool SameDayShipping { get; set; }
        public bool ThreeDaysDelivery { get; set; }
        public bool FiveDaysDelivery { get; set; }
        public bool SevenDaysDelivery { get; set; }
        public bool FreeShipping { get; set; }
        public bool DeliveryFromStock { get; set; }
        public bool PreOrderedProduct { get; set; }
        public bool LimitedStock { get; set; }
        public bool AskStock { get; set; }
        public bool CampaignedProduct { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
