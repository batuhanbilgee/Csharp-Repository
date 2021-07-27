using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class ProductToCategoryMap:BaseMap<ProductToCategory>
    {
        public ProductToCategoryMap()
        {
            ToTable("dbo.ProductToCategories");
            Property(x => x.SortOrder).IsOptional();
            Property(x => x.ProductId).IsRequired();
            Property(x => x.CategoryId).IsRequired();
        }
    }
}
