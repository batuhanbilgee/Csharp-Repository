using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class SpecToProduct:BaseEntity
    {
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [ForeignKey("SpecGroup")]
        public int SpecGroupId { get; set; }
        public SpecGroup SpecGroup { get; set; }
        [ForeignKey("SpecName")]
        public int SpecNameId { get; set; }
        public SpecName SpecName { get; set; }
        [ForeignKey("SpecValue")]
        public int SpecValueId { get; set; }
        public SpecValue SpecValue { get; set; }
    }
}
