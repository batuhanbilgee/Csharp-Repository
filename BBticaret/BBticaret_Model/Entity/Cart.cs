using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class Cart:BaseEntity
    {
        //public Cart()
        //{
        //    CartItems = new HashSet<CartItem>();
        //    QuickCarts = new HashSet<QuickCart>();
        //}
        public string SessionId { get; set; }
        public bool Locked { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [ForeignKey("ShopCampaigns")]
        public int ShopCampaingsId { get; set; }
        public ShopCampaigns ShopCampaigns { get; set; }
        [ForeignKey("Member")]
        public int MemberId { get; set; }
        public Member Member { get; set; }
        [ForeignKey("ShopToken")]
        public int ShopTokenId { get; set; }
        public ShopToken ShopToken { get; set; }

        //public ICollection<CartItem> CartItems { get; set; }
        //public ICollection<QuickCart> QuickCarts { get; set; }


    }
}
