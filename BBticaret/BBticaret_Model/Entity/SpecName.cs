using BBticaret_Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class SpecName:BaseEntity
    {
        //public SpecName()
        //{
        //    SpecValues = new HashSet<SpecValue>();
        //    SpecToProducts = new HashSet<SpecToProduct>();
        //}
        public string Name { get; set; }
        public string Slug { get; set; }
        public SpecNameChoiceType ChoiceType { get; set; }
        public int SortOrder { get; set; }
        public bool Status { get; set; }
        [ForeignKey("SpecGroup")]
        public int SpecGroupId { get; set; }
        public SpecGroup SpecGroup { get; set; }

        //public ICollection<SpecValue> SpecValues { get; set; }
        //public ICollection<SpecToProduct> SpecToProducts { get; set; }
    }
}
