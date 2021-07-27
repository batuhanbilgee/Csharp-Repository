using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class ProductCommentMap:BaseMap<ProductComment>
    {
        public ProductCommentMap()
        {
            ToTable("dbo.ProductComments");
            Property(x => x.Title).HasMaxLength(255).IsRequired();
            Property(x => x.Content).HasMaxLength(65535).IsRequired();
            Property(x => x.Status).IsRequired();
            Property(x => x.Rank).IsRequired();
            Property(x => x.IsAnonymous).IsRequired();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.MemberId).IsOptional();
            Property(x => x.ProductId).IsOptional();
            

        }
    }
}
