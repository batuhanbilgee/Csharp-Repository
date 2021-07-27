using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class LocationMap:BaseMap<Location>
    {
        public LocationMap()
        {
            ToTable("Location");
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.Status).IsRequired();
            Property(x => x.Predefined).IsOptional();
            Property(x => x.CountryId).IsOptional();
            Property(x => x.RegionId).IsOptional();
        }
    }
}
