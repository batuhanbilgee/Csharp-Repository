using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class OrderUserNote:BaseEntity
    {
        public string UserEmail { get; set; }
        public string UserFirstname { get; set; }
        public string UserSurname { get; set; }
        public string Note { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
