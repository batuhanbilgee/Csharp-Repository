using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class Label:BaseEntity
    {
        //public Label()
        //{
        //    LabelToProducts = new HashSet<LabelToProduct>();
        //}
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public bool HasChildren { get; set; }
        public string Slug { get; set; }
        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public bool Status { get; set; }
        public int LabelId { get; set; }
        public Label ParentLabel { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        //public ICollection<LabelToProduct> LabelToProducts { get; set; }

    }
}
