using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class CurrentAccountMap:BaseMap<CurrentAccount>
    {
        public CurrentAccountMap()
        {
            ToTable("dbo.CurrentAccount");
            Property(x => x.Code).HasMaxLength(255).IsOptional();
            Property(x => x.Title).HasMaxLength(255).IsRequired();
            Property(x => x.Balance).IsOptional();
            Property(x => x.RiskLimit).IsOptional();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.MemberId).IsOptional();
            
        }
    }
}
