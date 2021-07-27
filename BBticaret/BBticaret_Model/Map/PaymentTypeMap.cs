using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class PaymentTypeMap:BaseMap<PaymentType>
    {
        public PaymentTypeMap()
        {
            ToTable("dbo.PaymentTypes");
            Property(x => x.Name).HasMaxLength(255).IsRequired();
        }
    }
}
