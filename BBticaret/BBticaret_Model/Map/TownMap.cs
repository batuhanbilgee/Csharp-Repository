using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class TownMap:BaseMap<Town>
    {
        public TownMap()
        {
            ToTable("dbo.Towns");
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.Status).IsRequired();
            Property(x => x.LocationId).IsOptional();
            Property(x => x.TownGroupId).IsOptional();
        }
    }
}
