using BBticaret_Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class User:BaseEntity
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public UserStatus Status { get; set; }
        public bool IsOwner { get; set; }
        public bool SmsApproved { get; set; }
        [ForeignKey("ShopUserlevel")]
        public int UserLevelId { get; set; }
        public ShopUserlevel ShopUserlevel { get; set; }

    }
}
