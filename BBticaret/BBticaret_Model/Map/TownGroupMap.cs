using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class TownGroupMap:BaseMap<TownGroup>
    {
        public TownGroupMap()
        {
            ToTable("dbo.TownGroups");
            Property(x => x.Name)
                .HasMaxLength(255)
                .IsRequired();
            Property(x => x.Name)   
               .IsOptional();
        }
    }
}
