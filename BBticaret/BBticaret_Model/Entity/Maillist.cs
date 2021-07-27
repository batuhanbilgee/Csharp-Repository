using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class Maillist:BaseEntity
    {
        //public Maillist()
        //{
        //    Orders = new HashSet<Order>();
        //}
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime LastMailSentDate { get; set; }
        public string CreatorIpAddress { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [ForeignKey("MaillistGroup")]
        public int MailListGroupId { get; set; }
        public MaillistGroup MaillistGroup { get; set; }
        //public ICollection<Order> Orders { get; set; }

    }
}
