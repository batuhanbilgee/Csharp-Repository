using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class QuickCart:BaseEntity
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string ShortUrl { get; set; }
        public int CartId { get; set; }
        public Cart Cart { get; set; }
    }
}
