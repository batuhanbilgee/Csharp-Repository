using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class ShopUserlevel:BaseEntity
    {
        //public ShopUserlevel()
        //{
        //    Users = new HashSet<User>();
        //}
        public string Label { get; set; }
        public string Roles { get; set; }
        //public ICollection<User> Users { get; set; }

    }
}
