using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class DistributorToProductMap:BaseMap<DistributorToProduct>
    {
        public DistributorToProductMap()
        {
            ToTable("dbo.DistributorToProducts");
            Property(x => x.DistributorId).IsRequired();
            Property(x => x.ProductId).IsRequired();
        }
    }
}
