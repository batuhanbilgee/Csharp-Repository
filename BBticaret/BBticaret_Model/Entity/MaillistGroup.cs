using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class MaillistGroup:BaseEntity
    {
        //public MaillistGroup()
        //{
        //    Maillists = new HashSet<Maillist>();
        //}
        public string Name { get; set; }
        //public ICollection<Maillist> Maillists { get; set; }
    }
}
