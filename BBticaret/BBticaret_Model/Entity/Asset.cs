using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class Asset:BaseEntity
    {
        //public Asset()
        //{
        //    Themes = new HashSet<Theme>();
        //}
        public int Key { get; set; }
        public string ContentType { get; set; }

        public string Attachment { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAd { get; set; }
        //public ICollection<Theme> Themes { get; set; }

    }
}
