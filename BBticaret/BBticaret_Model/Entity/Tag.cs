using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class Tag:BaseEntity
    {
        //public Tag()
        //{
        //    ProductToTags = new HashSet<ProductToTag>();
        //}
        public string Name { get; set; }
        public int Count { get; set; }
        public string PageTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        //public ICollection<ProductToTag> ProductToTags { get; set; }
    }
}
