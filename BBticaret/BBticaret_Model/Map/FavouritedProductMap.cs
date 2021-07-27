using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class FavouritedProductMap:BaseMap<FavouritedProduct>
    {
        public FavouritedProductMap()
        {
            ToTable("dbo.FavouritedProducts");
            Property(x => x.MemberId).IsRequired();
            Property(x => x.ProductId).IsRequired();
        }
    }
}
