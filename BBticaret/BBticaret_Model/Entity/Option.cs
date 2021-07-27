using BBticaret_Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class Option:BaseEntity
    {
        //public Option()
        //{
        //    OptionToProducts = new HashSet<OptionToProduct>();
        //}
        public string Title { get; set; }
        public string Slug { get; set; }
        public int SortOrder { get; set; }
        public OptionLogo Logo { get; set; }
        [ForeignKey("OptionGroup")]
        public int OptionGroupId { get; set; }
        public OptionGroup OptionGroup { get; set; }
        public string Attachment { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        //public ICollection<OptionToProduct> OptionToProducts { get; set; }


    }
}
