using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class ProductToTagMap:BaseMap<ProductToTag>
    {
        public ProductToTagMap()
        {
            ToTable("dbo.ProductToTags");
            Property(x => x.ProductId).IsRequired();
            Property(x => x.TagId).IsRequired();
        }
    }
}
