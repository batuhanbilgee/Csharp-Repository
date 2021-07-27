using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class ExtraInfoToProduct:BaseEntity
    {
        public string Value { get; set; }
        [ForeignKey("ExtraInfo")]
        public int ExtraInfoId { get; set; }
        public ExtraInfo ExtraInfo { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
