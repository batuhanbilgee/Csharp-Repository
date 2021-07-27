using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class ErrorMap:BaseMap<Error>
    {
        public ErrorMap()
        {
            ToTable("dbo.Errors");
            Property(x => x.Code)
                .IsOptional();
            Property(x => x.ErrorMessage)
                .IsOptional();
            Property(x => x.ErrorCode)
               .IsOptional();


        }
    }
}
