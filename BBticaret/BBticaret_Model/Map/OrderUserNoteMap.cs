using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class OrderUserNoteMap:BaseMap<OrderUserNote>
    {
        public OrderUserNoteMap()
        {
            ToTable("dbo.OrderUserNotes");
            Property(x => x.UserEmail).HasMaxLength(255).IsRequired();
            Property(x => x.UserFirstname).HasMaxLength(255).IsOptional();
            Property(x => x.UserSurname).HasMaxLength(255).IsOptional();
            Property(x => x.Note).HasMaxLength(65535).IsRequired();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsRequired();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsRequired();
            Property(x => x.OrderId).IsRequired();
        }
    }
}
