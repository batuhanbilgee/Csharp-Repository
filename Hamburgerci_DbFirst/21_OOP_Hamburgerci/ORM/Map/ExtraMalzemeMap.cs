using _21_OOP_Hamburgerci.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OOP_Hamburgerci.ORM.Map
{
    public class ExtraMalzemeMap:BaseMap<ExtraMalzeme>
    {
        public ExtraMalzemeMap()
        {
            ToTable("dbo.EkstraMalzeme");
           

            Property(x => x.EkstraMalzemeAdi)
                .HasMaxLength(100)
                .HasColumnOrder(2)
                .IsRequired();

            Property(x => x.EkstraMalzemeFiyati)
                .HasColumnOrder(3)
                .IsRequired();
        }
    }
}
