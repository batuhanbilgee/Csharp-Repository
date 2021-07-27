using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class CartItemMap:BaseMap<CartItem>
    {
        public CartItemMap()
        {
            ToTable("dbo.CartItems");
            Property(x => x.ParentProductId).IsOptional();
            Property(x => x.Quantity).IsOptional();
            Property(x => x.CategoryId).IsOptional();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.CartId).IsOptional();
            Property(x => x.ProductId).IsOptional();
        }
    }
}
