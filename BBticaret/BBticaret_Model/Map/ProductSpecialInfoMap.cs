using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class ProductSpecialInfoMap:BaseMap<ProductSpecialInfo>
    {
        public ProductSpecialInfoMap()
        {
            ToTable("dbo.ProductSpecialInfos");
            Property(x => x.Title).HasMaxLength(255).IsRequired();
            Property(x => x.Content).HasMaxLength(65535).IsRequired();
            Property(x => x.Status).IsRequired();
            Property(x => x.ProductId).IsRequired();
        }
    }
}
