using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class RegionMap:BaseMap<Region>
    {
        public RegionMap()
        {
            ToTable("dbo.Regions");
            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(255);
            Property(x => x.CountryId)
                .IsRequired();
            
            
        }
    }
}
