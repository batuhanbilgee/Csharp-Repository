using BBticaret_Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class Category:BaseEntity
    {
        //public Category()
        //{
        //    ProductToCategories = new HashSet<ProductToCategory>();
        //    PurchaseLimitationItems = new HashSet<PurchaseLimitationItem>();
        //}
        public string Name { get; set; }
        public string Slug { get; set; }
        public int SortOrder { get; set; }
        public bool Status { get; set; }
        public string DistributorCode { get; set; }
        public int Percent { get; set; }
        public string ImageFile { get; set; }
        public string Distributor { get; set; }
        public int DisplayShowcaseContent { get; set; }
        public string ShowcaseContent { get; set; }
        public CategoryShowcaseContentDisplayType ShowcaseContentDisplayType { get; set; }
        public int DisplayShowcaseFooterContent { get; set; }
        public string ShowCaseFooterContent { get; set; }
        public int ShowcaseFooterContentDisplayType { get; set; }
        public bool HasChildren { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string PageTitle { get; set; }
        public int CategoryId { get; set; }
        public Category ParentCategory { get; set; }
        public string Attachment { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        //public ICollection<ProductToCategory> ProductToCategories { get; set; }
        //public ICollection<PurchaseLimitationItem> PurchaseLimitationItems { get; set; }



    }
}
