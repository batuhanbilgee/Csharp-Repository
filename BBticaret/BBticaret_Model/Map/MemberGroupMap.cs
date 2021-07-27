using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class MemberGroupMap:BaseMap<MemberGroup>
    {
        public MemberGroupMap()
        {
            ToTable("dbo.MemberGroups");
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.PriceIndex).IsRequired();
            Property(x => x.Name).HasMaxLength(512).IsRequired();
        }
    }
}
