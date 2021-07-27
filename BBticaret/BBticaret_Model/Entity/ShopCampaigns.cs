using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class ShopCampaigns:BaseEntity
    {
        //public ShopCampaigns()
        //{
        //    Carts = new HashSet<Cart>();
        //}
        public string Label { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        //public ICollection<Cart> Carts { get; set; }


    }
}
