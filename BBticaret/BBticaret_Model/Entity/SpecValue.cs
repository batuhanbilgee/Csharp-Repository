using BBticaret_Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class SpecValue:BaseEntity
    {
        //public SpecValue()
        //{
        //    SpecToProducts = new HashSet<SpecToProduct>();
        //}
        public string Name { get; set; }
        public string Slug { get; set; }
        public int SortOrder { get; set; }
        public SpecValueLogo Logo { get; set; }
        public bool Status { get; set; }
        public string Attachment { get; set; }
        [ForeignKey("SpecGroup")]
        public int SpecGroupId { get; set; }
        public SpecGroup SpecGroup { get; set; }
        [ForeignKey("SpecName")]
        public int SpecNameId { get; set; }
        public SpecName SpecName { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        //public ICollection<SpecToProduct> SpecToProducts { get; set; }

    }
}
