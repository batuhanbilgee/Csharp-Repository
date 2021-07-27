using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class Brand:BaseEntity
    {
        //public Brand()
        //{
        //    Products = new HashSet<Product>();
        //    PurchaseLimitationItems = new HashSet<PurchaseLimitationItem>();
        //}
        public string Name { get; set; }
        public string Slug { get; set; }
        public int SortOrder { get; set; }
        public bool Status { get; set; }
        public string DistributorCode { get; set; }
        public string Distributor { get; set; }
        public string ImageFile { get; set; }
        public string ShowcaseContent { get; set; }
        public bool DisplayShowcaseContent { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string PageTitle { get; set; }
        public string Attachment { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        //public ICollection<Product> Products { get; set; }
        //public ICollection<PurchaseLimitationItem> PurchaseLimitationItems { get; set; }
    }
}
