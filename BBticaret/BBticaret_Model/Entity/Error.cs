using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class Error:BaseEntity
    {
        //public Error()
        //{
        //    Payments = new HashSet<Payment>();
        //}
        public int Code { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorCode { get; set; }

        //public ICollection<Payment> Payments { get; set; }

    }
}
