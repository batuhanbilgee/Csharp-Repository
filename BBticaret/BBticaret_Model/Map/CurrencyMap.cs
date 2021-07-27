using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class CurrencyMap:BaseMap<Currency>
    {
        public CurrencyMap()
        {
            ToTable("dbo.Currency");
            Property(x => x.Label).HasMaxLength(50).IsOptional();
            Property(x => x.BuyingPrice).IsOptional();
            Property(x => x.SellingPrice).IsOptional();
            Property(x => x.Abbr).HasMaxLength(5).IsOptional();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.Status).IsOptional();
            Property(x => x.IsPrimary).IsOptional();



        }
    }
}
