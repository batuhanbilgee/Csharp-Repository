using _21_OOP_Hamburgerci.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OOP_Hamburgerci.ORM.Map
{
    public class SiparisToExtraMalzemeMap : BaseMap<SiparisToExtraMalzeme>
    {
        public SiparisToExtraMalzemeMap()
        {
            ToTable("dbo.SiparisToExtraMalzemes");

            Property(x => x.SiparisId)
                .IsRequired()
                .HasColumnOrder(2);

            Property(x => x.ExtraMalzemeId)
                .IsRequired()
                .HasColumnOrder(3);
        }
    }
}
