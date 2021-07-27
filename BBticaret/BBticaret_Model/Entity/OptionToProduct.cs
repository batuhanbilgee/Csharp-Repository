using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class OptionToProduct:BaseEntity
    {
        public int ParentProductId { get; set; }
        [ForeignKey("OptionGroup")]
        public int OptionGroupId { get; set; }
        public OptionGroup OptionGroup { get; set; }
        [ForeignKey("Option")]
        public int OptionId { get; set; }
        public Option Option { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
