using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class MaillistMap:BaseMap<Maillist>
    {
        public MaillistMap()
        {
            ToTable("dbo.Maillists");
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.Email).HasMaxLength(255).IsRequired();
            Property(x => x.LastMailSentDate).HasColumnType("datetime2").IsOptional();
            Property(x => x.CreatorIpAddress).HasMaxLength(64).IsOptional();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.MailListGroupId).IsOptional();


        }
    }
}
