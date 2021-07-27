using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class MaillistGroupMap:BaseMap<MaillistGroup>
    {
        public MaillistGroupMap()
        {
            ToTable("dbo.MaillistGroups");
            Property(x => x.Name).HasMaxLength(255).IsRequired();
        }
    }
}
