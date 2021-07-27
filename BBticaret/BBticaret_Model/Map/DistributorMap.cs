using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class DistributorMap:BaseMap<Distributor>
    {
        public DistributorMap()
        {
            ToTable("dbo.Distributors");
            Property(x => x.Name).IsRequired().HasMaxLength(255);
            Property(x => x.Email).IsOptional().HasMaxLength(255);  
            Property(x => x.Phone).IsOptional().HasMaxLength(255);
            Property(x => x.ContactPerson).IsOptional().HasMaxLength(255);
            Property(x => x.PreferanceId).IsOptional();

        }
    }
}
