using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class CountryMap:BaseMap<Country>
    {
        public CountryMap()
        {
            ToTable("dbo.Countries");
            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(255);
            Property(x => x.Code)
                .IsRequired()
                .HasMaxLength(255);
            Property(x => x.Status)
               .IsRequired();
              

        }
    }
}
