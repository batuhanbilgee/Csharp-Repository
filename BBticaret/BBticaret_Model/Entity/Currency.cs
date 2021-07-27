using BBticaret_Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class Currency:BaseEntity
    {
        //public Currency()
        //{
        //    Products = new HashSet<Product>();
        //}
        public string Label { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public string Abbr { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Status { get; set; }
        public CurrencyIsPrimary IsPrimary { get; set; }
       // public ICollection<Product> Products { get; set; }
    }
}
